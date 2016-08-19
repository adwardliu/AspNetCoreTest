using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

namespace ConsoleApplication
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            // services.AddMvc(options =>
            // {
            //     options.Filters.Add(typeof(SimpleResourceFilterAttribute));
            //     options.Filters.Add(typeof(SimpleActionFilterAttribute));
            //     options.Filters.Add(typeof(SimpleExceptionFilterAttribute));
            //     options.Filters.Add(typeof(SimpleResultFilterAttribute));
            // });
            services.AddScoped<IRepository<User>, UserRepository>();
        }
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            // loggerFactory.WithFilter(new FilterLoggerSettings {
            //     {"Microsoft", LogLevel.Trace},
            //     {"ConsoleApplication",LogLevel.Debug}
            // }).AddConsole();
            loggerFactory.AddConsole();
            loggerFactory.AddDebug();
            loggerFactory.AddNLog();
            // app.Run(async context =>
            // {
            //     await context.Response.WriteAsync("Hello World!");
            // });
            app.UseMvc();
        }
    }
}