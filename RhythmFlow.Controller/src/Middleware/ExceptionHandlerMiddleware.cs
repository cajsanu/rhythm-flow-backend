using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace RhythmFlow.Controller.src.Middleware
{
    public class ExceptionHandlerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(ex, context);
            }
        }

        private static async Task HandleExceptionAsync(Exception exception, HttpContext context)
        {
            var (status, message) = ExceptionMapper.MapException(exception);

            // Customise response
            var exceptionResponse = new
            {
                StatusCode = status,
                Message = message,
                // Details = exception.Message, // Only for development
                Timestamp = DateTime.UtcNow
            };

            // Serialize the error response to JSON
            var responsePayload = JsonSerializer.Serialize(exceptionResponse, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            // Set HTTP response details
            context.Response.StatusCode = status;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsync(responsePayload);
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