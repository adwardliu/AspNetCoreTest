using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class HelloworldTooMiddleware{
        private readonly RequestDelegate _next;
        public HelloworldTooMiddleware(RequestDelegate next){
           _next = next;
        }

        public async Task Invoke(HttpContext context){
            await context.Response.WriteAsync("Hello World Too!");
            //await _next(context);
        }
    }
}