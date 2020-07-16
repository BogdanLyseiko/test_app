using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestProject.Models.Constatns;

namespace TestProject.Filters
{
    public class ApiExceptionFilter : ExceptionFilterAttribute
    {
        private readonly ILogger<ApiExceptionFilter> logger;
        public ApiExceptionFilter (ILogger<ApiExceptionFilter> logger)
        {
            this.logger = logger;
        }
        public override void OnException(ExceptionContext context)
        {
            logger.LogError($"Message: {context.Exception.Message}\nTrace: {context.Exception.StackTrace}");
            context.HttpContext.Response.StatusCode = 500;
            context.Result = new JsonResult(ApiErrors.UNHANDLED_EXCEPTION_OCCURED);

            base.OnException(context);
        }
    }
}