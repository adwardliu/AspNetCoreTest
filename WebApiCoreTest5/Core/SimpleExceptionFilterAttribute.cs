using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    public class SimpleExceptionFilterAttribute : Attribute, IExceptionFilter
    {
        private ILogger<SimpleExceptionFilterAttribute> _logger;
        public SimpleExceptionFilterAttribute(ILoggerFactory loggerFactory){
            _logger = loggerFactory.CreateLogger<SimpleExceptionFilterAttribute>();
        }
        public void OnException(ExceptionContext context)
        {
            _logger.LogError("Exception Execute! Message:" + context.Exception.Message);
            context.ExceptionHandled = true;
        }
    }
}