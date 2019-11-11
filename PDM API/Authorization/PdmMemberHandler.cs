using Microsoft.AspNetCore.Authorization;
using PDM_API.Providers;
using System.Threading.Tasks;

namespace PDM_API.Authorization
{
    public class PdmMemberHandler : AuthorizationHandler<PdmMemberRequirement>
    {
        IUserProvider _userProvider;

        public PdmMemberHandler(IUserProvider userProvider)
        {
            _userProvider = userProvider;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, PdmMemberRequirement requirement)
        {
            var currentUser = _userProvider.GetUserAsync().Result;

            if (currentUser != null)
            {
                if (currentUser.HasReadAllRole)
                {
                    context.Succeed(requirement);
                }

                if (currentUser.FieldAccess != null && currentUser.FieldAccess.Count > 0)
                {
                    context.Succeed(requirement);
                }
            }
            else
            {
                context.Fail();
            }

            return Task.CompletedTask;
        }
    }
}
