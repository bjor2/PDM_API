using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using PDM_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDM_API.Filters
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {

        public override void OnException(ExceptionContext context)
        {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "test" || Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "prod")
            {
                context.Result = new ObjectResult(new Error() { Message = "Error message (only in dev or test): " + context.Exception.Message }) { StatusCode = 555 };
            }
        }
    }

}
