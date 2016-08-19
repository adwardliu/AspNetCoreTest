using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    public class SimpleResultFilterAttribute : Attribute, IResultFilter
    {
        private ILogger<SimpleResultFilterAttribute> _logger;
        public SimpleResultFilterAttribute(ILoggerFactory loggerFactory){
            _logger = loggerFactory.CreateLogger<SimpleResultFilterAttribute>();
        }
        public void OnResultExecuted(ResultExecutedContext context)
        {
            _logger.LogInformation("ResultFilter Executed.");
        }

        public void OnResultExecuting(ResultExecutingContext context)
        {
            _logger.LogInformation("ResultFilter Executing.");
        }
    }
}