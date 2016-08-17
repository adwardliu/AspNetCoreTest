using System;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace ConsoleApplication
{
    public class SimpleResourceFilterAttribute : Attribute, IResourceFilter
    {
        private ILogger<SimpleResourceFilterAttribute> _logger;
        public SimpleResourceFilterAttribute(ILoggerFactory loggerFactory){
            _logger = loggerFactory.CreateLogger<SimpleResourceFilterAttribute>();
        }
        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            _logger.LogInformation("ResourceFilter Executed.");
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            _logger.LogInformation("ResourceFilter Executing.");
        }
    }
}