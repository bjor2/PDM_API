using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Graph;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using PDM_API.Extensions;
using PDM_API.Services;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PDM_API.Providers
{

    public class OnBehalfOfMsGraphAuthenticationProvider : IAuthenticationProvider
    {
        readonly IConfiguration _config;
        readonly IDistributedCache _distributedCache;
        readonly ILoggerFactory _loggerFactory;
        readonly ILogger _logger;
        readonly IDataProtectionProvider _dataProtectionProvider;
        readonly IHttpContextAccessor _httpContextAccessor;

        readonly string _authority;
        readonly string _clientId;
        readonly string _clientSecret;

        public OnBehalfOfMsGraphAuthenticationProvider(
            IConfiguration config,
            IDistributedCache distributedCache,
            ILoggerFactory loggerFactory,
            IDataProtectionProvider dataProtectionProvider,
            IHttpContextAccessor httpContextAccessor)
        {
            _config = config;
            _distributedCache = distributedCache;
            _loggerFactory = loggerFactory;
            _dataProtectionProvider = dataProtectionProvider;
            _httpContextAccessor = httpContextAccessor;
            _authority = _config["AzureAd:Instance"] + _config["AzureAd:TenantId"];
            _clientId = _config["AzureAd:ClientId"];
            _clientSecret = _config["AzureAd:ClientSecret"];

            _logger = _loggerFactory.CreateLogger("OnBehalfOfMsGraphAuthenticationProvider");
        }

        public async Task AuthenticateRequestAsync(HttpRequestMessage request)
        {
            var httpContext = _httpContextAccessor.HttpContext;

            //Get the access token used to call this API
            string token = await httpContext.GetTokenAsync("access_token");

            //We are passing an *assertion* to Azure AD about the current user
            //Here we specify that assertion's type, that is a JWT Bearer token
            string assertionType = "urn:ietf:params:oauth:grant-type:jwt-bearer";

            //User name is needed here only for ADAL, it is not passed to AAD
            //ADAL uses it to find a token in the cache if available
            var user = httpContext.User;
            string userName = user.FindFirstValue(ClaimTypes.Upn) ?? user.FindFirstValue(ClaimTypes.Email);
            //_logger.LogInformation("UPN: " + user.FindFirstValue(ClaimTypes.Upn) + ", Email: " + user.FindFirstValue(ClaimTypes.Email));

            var userAssertion = new UserAssertion(token, assertionType, userName);

            //Construct the token cache
            var cache = new DistributedTokenCache(user, _distributedCache, _loggerFactory, _dataProtectionProvider);

            var authContext = new AuthenticationContext(_authority, true, cache);
            var clientCredential = new ClientCredential(_clientId, _clientSecret);

            //Acquire access token
            var result = await authContext.AcquireTokenAsync("https://graph.microsoft.com", clientCredential, userAssertion);
            //Set the authentication header
            request.Headers.Authorization = new AuthenticationHeaderValue(result.AccessTokenType, result.AccessToken);
        }
    }
}
