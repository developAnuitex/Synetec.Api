using Microsoft.AspNetCore.Http;
using Synetec.Shared.Common;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Synetec.Api.Middelwares
{
    public class ErrorHandlingMiddleware
    {
        private RequestDelegate _next;
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (AppException ex)
            {
                string errorContent = JsonSerializer.Serialize(ex.Descriptions);
                context.Response.StatusCode = (int)ex.StatusCode;
                await context.Response.WriteAsync(errorContent);
            }
            catch (Exception)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await context.Response.WriteAsync(HttpStatusCode.InternalServerError.ToString());

            }
        }
    }
}
