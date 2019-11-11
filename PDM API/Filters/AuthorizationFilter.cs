using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using PDM_API.Models;
using System.Collections.Generic;
using System.Linq;

namespace PDM_API.Filters
{
    public class AuthorizationFilter : IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var descriptors = context.ActionDescriptor as ControllerActionDescriptor;
            var user = context.HttpContext.User;

            if (descriptors.FilterDescriptors.Any(x => x.Filter is IAllowAnonymousFilter))
            {
                return;
            }
            return;
            if (user.Identity.IsAuthenticated)
            {
                context.Result = new ObjectResult(new Error() { Message = "Awesome job!.", Code = 202}) { StatusCode = StatusCodes.Status202Accepted};
                return;
            }
            context.Result = new ObjectResult(new Error() { Message = "Not authenticated to use the API.", Code = 401 }) { StatusCode = StatusCodes.Status401Unauthorized };
            return;
        }
    }
}
