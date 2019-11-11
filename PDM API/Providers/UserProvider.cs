using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using PDM_API.Extensions;
using PDM_API.Models.Auth;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PDM_API.Providers
{

    public class UserProvider : IUserProvider
    {
        readonly IHttpContextAccessor _ContextAccessor;
        readonly ILogger _logger;
        readonly GroupMembershipProvider _GroupMembershipProvider;
        readonly IDistributedCache _cache;

        const string PDM_GROUP_PREFIX = "pdm_";
        const string PDM_EXTERNAL_GROUP_PREFIX = "azappl pdm ";

        public UserProvider(IHttpContextAccessor contextAccessor, ILoggerFactory loggerFactory, GroupMembershipProvider groupMembershipProvider, IDistributedCache cache)
        {
            _ContextAccessor = contextAccessor;
            _logger = loggerFactory.CreateLogger("UserProvider");
            _GroupMembershipProvider = groupMembershipProvider;
            _cache = cache;
        }

        public async Task<ProdComUser> GetUserAsync()
        {
            return await GetUserAsync(GetUserName());
        }

        public string GetUserName()
        {
            string identityName = _ContextAccessor.HttpContext.User.Identity.Name;
            // Remove [idp] from user name for external users           

            if (identityName == null)
            {
                var context = _ContextAccessor.HttpContext;
                var user = context.User;
                foreach (var v in context.Request.Headers) {
                    var name = v.Key;
                    var val = v.Value;
                    if (v.Key == "Authorization") {
                        var claims = GetGlaimsFromToken(v.Value);
                        return claims.First(claim => claim.Type == "appid").Value;
                    }
                    
                }
                return null;
            }
            else { 
                string userName = identityName.Substring(identityName.IndexOf("#") + 1);
                return userName;
            }
        }

        public List<Claim> GetGlaimsFromToken(string jwtToken)
        {
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(jwtToken.Replace("Bearer ", ""));
            var tokenS = handler.ReadToken(jwtToken.Replace("Bearer ", "")) as JwtSecurityToken;
            return tokenS.Claims.ToList();
        }

        public async Task<ProdComUser> GetUserAsync(string userName)
        {
            _logger.LogInformation("GetUserAsync: " + userName);

            if (String.IsNullOrWhiteSpace(userName))
            {
                _logger.LogWarning("Username empty or null");
                return null;
            }

            string curFieldName = null;

            ProdComUser user = await GetCachedUserAsync(userName);

            if (user != null)
            {
                _logger.LogInformation("Found cached user: " + user.Username);
            }
            else
            {
                _logger.LogInformation("User NOT found in cache, creating");
                //User not found, initiate new user and add to cache
                user = new ProdComUser { Username = userName };

                foreach (var curGrup in await _GroupMembershipProvider.GetGroupsFromGraphAsync())
                {
                    if (curGrup.Value.ToLower() == "pdm_read_all")
                    {
                        user.HasReadAllRole = true;
                        break;
                    }
                    if (TranslateGroupToField(curGrup.Value, out curFieldName))
                    {
                        user.FieldAccess.Add(curFieldName);
                    }
                }

                //add user to cache, set expiration of cache entry
                var cacheEntryOptions = new DistributedCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromHours(1));
                _cache.Set(userName, user.ToByteArray(), cacheEntryOptions);
            }

            var userType = "";

            if (user.HasReadAllRole)
            {
                userType += "ReadAll, ";
            }

            if (user.FieldAccess != null)
            {
                foreach (var curField in user.FieldAccess)
                {
                    userType += (curField + ", ");
                }
            }

            _logger.LogInformation("User access: " + userType);

            return user;

        }

        async Task<ProdComUser> GetCachedUserAsync(string username)
        {
            var userBytes = await _cache.GetAsync(username);

            if (userBytes != null)
            {
                return userBytes.FromByteArray<ProdComUser>();
            }

            return null;
        }

        bool TranslateGroupToField(string groupName, out string fieldName)
        {
            fieldName = null;

            if (!String.IsNullOrWhiteSpace(groupName))
            {
                var groupNameLowered = groupName.ToLowerInvariant();

                // Internal user
                if (groupNameLowered.IndexOf(PDM_GROUP_PREFIX) == 0)
                {
                    fieldName = groupNameLowered.Replace(PDM_GROUP_PREFIX, "");
                    return true;
                }
                // External user
                else if (groupNameLowered.IndexOf(PDM_EXTERNAL_GROUP_PREFIX) == 0) 
                {
                    fieldName = groupNameLowered.Replace(PDM_EXTERNAL_GROUP_PREFIX, "");
                    return true;
                }
            }

            return false;
        }
    }
}
