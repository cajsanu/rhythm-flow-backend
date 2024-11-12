using System.Net;
using Microsoft.AspNetCore.Http;

namespace RhythmFlow.Controller.src.Middleware
{
    public class GlobalExceptionHandlerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                HandleExceptionAsync(ex);
            }
        }

        private static void HandleExceptionAsync(Exception exception)
        {
            ExceptionMapper.MapException(exception);
        }
    }

    // Static helper class for mapping exceptions to status codes and messages
    // Should this be extracted to a separate file?
    public static class ExceptionMapper
    {
        private static readonly Dictionary<Type, (int StatusCode, string Message)> ExceptionMappings = new()
    {
        { typeof(InvalidOperationException), ((int)HttpStatusCode.BadRequest, "The operation is not valid.") },
        { typeof(KeyNotFoundException), ((int)HttpStatusCode.NotFound, "The requested resource was not found.") }
    };

        public static (int StatusCode, string Message) MapException(Exception exception)
        {
            return ExceptionMappings.TryGetValue(exception.GetType(), out var result)
                ? result
                : ((int)HttpStatusCode.InternalServerError, "An unexpected error occurred. Please try again later.");
        }
    }

}