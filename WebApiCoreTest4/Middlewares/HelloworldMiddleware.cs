using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    public class HelloworldMiddleware{
        private readonly RequestDelegate _next;
        public HelloworldMiddleware(RequestDelegate next){
           _next = next;
        }

        public async Task Invoke(HttpContext context){
            await context.Response.WriteAsync("Hello World!");
            await _next(context);
        }
    }
}