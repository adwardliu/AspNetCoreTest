using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    public class SimpleActionFilterAttribute : Attribute, IActionFilter
    {
        private ILogger<SimpleActionFilterAttribute> _logger;
        public SimpleActionFilterAttribute(ILoggerFactory loggerFactory){
            _logger = loggerFactory.CreateLogger<SimpleActionFilterAttribute>();
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("ActionFilter Executed.");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("ActionFilter Executing.");
        }
    }
}