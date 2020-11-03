using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace Boikon.WebApi.Middleware
{
    public class PatricksMiddleware
    {
        // Volgende in de pipeline
        private readonly RequestDelegate _next;

        public PatricksMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var rt1 = httpContext.Request.RouteValues.FirstOrDefault();
            Console.WriteLine($"{rt1.Key}: {rt1.Value}");
            //Console.WriteLine($"Heenweg: {httpContext.Request.Headers["Accept"]}");
            await _next(httpContext);
            //Console.WriteLine($"Terugweg: {httpContext.Response.Headers["Content-Type"]}");

        }
    }















    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class PatricksMiddlewareExtensions
    {
        public static IApplicationBuilder UsePatricksMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<PatricksMiddleware>();
        }
    }
}
