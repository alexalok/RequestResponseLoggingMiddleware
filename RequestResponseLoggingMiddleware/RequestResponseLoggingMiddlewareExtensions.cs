using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace RequestResponseLoggingMiddleware
{
    public static class RequestResponseLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestResponseLogging(this IApplicationBuilder builder, Func<HttpContext, bool> filterPredicate)
        {
            return builder.UseMiddleware<RequestResponseLoggingMiddleware>(filterPredicate);
        }
    }
}
