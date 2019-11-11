using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Swagger;
using System.Reflection;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using PDM_API.Providers;
using PDM_API.Authorization;
using Microsoft.AspNetCore.Http;

namespace PDM_API
{
    public class Startup
    {
        private readonly ILogger<Startup> _logger;
        public IConfiguration Configuration { get; }

        public Startup(ILogger<Startup> logger, IConfiguration configuration)
        {
            _logger = logger;
            Configuration = configuration;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Cache
            var redisUrl = Configuration["Cache:cacheUrl"];
            var useLocalInMemoryCache = String.IsNullOrWhiteSpace(redisUrl);

            if (useLocalInMemoryCache)
            {
                services.AddMemoryCache();
            }
            else
            {
                services.AddDistributedRedisCache(options =>
                {
                    options.Configuration = redisUrl;
                    options.InstanceName = "master";
                });
            }

            // Audiences
            var audiencesFromConfig = Configuration["AzureAd:Audiences"].Split(";");
            var audienceList = new List<string>();

            foreach (string curAudience in audiencesFromConfig)
            {
                if (!String.IsNullOrWhiteSpace(curAudience))
                {
                    audienceList.Add(curAudience);
                }
            }

            // Authentication
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
              .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, o =>
              {
                  o.Authority = Configuration["AzureAd:Instance"] + Configuration["AzureAd:TenantId"];
                  o.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                  {
                      ValidateLifetime = true,
                      ValidateIssuer = true,
                      ValidateAudience = true,
                      ValidAudiences = audienceList
                  };

                  o.SaveToken = true;
              });

            // SQL Connection
            //Change
            var pdMConnectionString = Configuration.GetConnectionString("pdmDatabase");

            if (!String.IsNullOrWhiteSpace(pdMConnectionString))
            {
                services.AddDbContext<PDMContext>();
            }
            else
            {
                throw new Exception("PDM CONNECTION STRING IS MISSING!");
            }

            // Swagger
            services.AddSwaggerGen(c => 
            {
                c.SwaggerDoc("internal", new Info
                {
                    Title = "PDM Internal API",
                    Version = "v2",
                    Description = "PDM Internal API is available for internal Equinor applications and users. The API gives read access to production data sets available from the PDM database in OMNIA. Access restrictions apply per gas / oil field. In order to get the access you need to apply via Access IT for one or more field based roles defined for the application Production Data Mart."
                });

                c.SwaggerDoc("external", new Info
                {
                    Title = "PDM External API",
                    Version = "v2",
                    Description = "PDM Internal API is available for external applications and users. The API gives read access to production data sets made available for external consumers from the PDM database in OMNIA. In order to get the access you need to contact license responsible in Equinor to arrange access."
                });

                c.AddSecurityDefinition("oauth2", new OAuth2Scheme
                {
                    Type = "oauth2",
                    Flow = "accessCode",
                    AuthorizationUrl = "https://login.microsoftonline.com/3aa4a235-b6e2-48d5-9195-7fcf05b459b0/oauth2/authorize?resource=" + Configuration["AzureAd:Resource"],
                    TokenUrl = "https://login.microsoftonline.com/3aa4a235-b6e2-48d5-9195-7fcf05b459b0/oauth2/token?resource=" + Configuration["AzureAd:Resource"],
                    Scopes = new Dictionary<string, string>{
                        { "actioncenter", "Access read operations" }
                    }
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

                c.OperationFilter<AuthOperationFilter>();
            });

            services.AddAuthorization(options =>
            {
                options.AddPolicy("Pdm.Member", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.Requirements.Add(new PdmMemberRequirement());
                });
                options.DefaultPolicy = options.GetPolicy("Pdm.Member");
            });
            services.AddMvc(c =>
            {
                var authPolicy = new AuthorizationPolicyBuilder()
                   .RequireAuthenticatedUser()
                   .Build();
                c.Filters.Add(new AuthorizeFilter(authPolicy));
                c.Filters.Add(new Filters.ExceptionFilter());
                c.Filters.Add(new Filters.AuthorizationFilter());
                
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Dependency injections
            services.AddSingleton(Configuration);
            services.AddTransient<HealthCheckService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient<IAuthorizationHandler, PdmMemberHandler>();
            services.AddTransient<OnBehalfOfMsGraphAuthenticationProvider, OnBehalfOfMsGraphAuthenticationProvider>();
            services.AddTransient<GroupMembershipProvider, GroupMembershipProvider>();
            services.AddTransient<IUserProvider, UserProvider>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseSwagger(c =>
            {
                c.PreSerializeFilters.Add((swaggerDoc, httpReq) => swaggerDoc.Host = httpReq.Host.Value);
            });
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/internal/swagger.json", "PDM Internal API");
                options.SwaggerEndpoint("/swagger/external/swagger.json", "PDM External API");
            });
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}