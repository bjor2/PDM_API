using Microsoft.AspNetCore.Authorization;

namespace PDM_API.Authorization
{
    public class PdmMemberRequirement : IAuthorizationRequirement
    {
        public PdmMemberRequirement()
        {
        }
    }
}
