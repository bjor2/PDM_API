using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PDM_API.Providers
{
    public class GroupMembershipProvider
    {
        IConfiguration _configuration;
        ILogger _logger;
        OnBehalfOfMsGraphAuthenticationProvider _onBehalfOfMsGraphAuthenticationProvider;

        public GroupMembershipProvider(IConfiguration configuration, ILoggerFactory loggerFactory, OnBehalfOfMsGraphAuthenticationProvider onBehalfOfMsGraphAuthenticationProvider)
        {
            _configuration = configuration;
            _logger = loggerFactory.CreateLogger("GroupMembershipProvider");
            _onBehalfOfMsGraphAuthenticationProvider = onBehalfOfMsGraphAuthenticationProvider;
        }

        async Task<IUserMemberOfCollectionWithReferencesPage> GetGroupsAsync()
        {
            var client = new GraphServiceClient(_onBehalfOfMsGraphAuthenticationProvider);
            return await client.Me.MemberOf.Request().GetAsync();
        }

        public async Task<Dictionary<string, string>> GetGroupsFromGraphAsync()
        {
            //_logger.LogInformation("GetGroupsFromGraphAsync");

            var result = new Dictionary<string, string>();

            try
            {
                var groupsFromGraph = await GetGroupsAsync();

                while (groupsFromGraph?.Count > 0)
                {
                    foreach (var directoryObject in groupsFromGraph)
                    {
                        if (directoryObject is Group)
                        {
                            Group group = directoryObject as Group;

                            //_logger.LogInformation("MemberOf: " + group.DisplayName);

                            result.Add(group.Id, group.DisplayName);
                        }
                    }

                    if (groupsFromGraph.NextPageRequest != null)
                    {
                        groupsFromGraph = await groupsFromGraph.NextPageRequest.GetAsync();
                    }
                    else
                    {
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while running GetGroupsFromGraphAsync");
                throw;
            }


            return result;
        }
    }
}
