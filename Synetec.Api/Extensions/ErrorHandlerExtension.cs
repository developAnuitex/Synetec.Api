using Microsoft.AspNetCore.Builder;
using Synetec.Api.Middelwares;

namespace Synetec.Api.Extensions
{
    public static class ErrorHandlerExtension
    {
        public static IApplicationBuilder UseErrorHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlingMiddleware>();
        }
    }
}
