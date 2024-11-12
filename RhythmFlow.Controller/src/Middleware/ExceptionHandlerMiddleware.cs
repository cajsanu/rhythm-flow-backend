using System.Text.Json;
using Microsoft.AspNetCore.Http;

// Extract mapper to separate file 
// How to inject this into program.cs

namespace RhythmFlow.Controller.src.Middleware
{
    public class ExceptionHandlerMiddleware : IMiddleware
    {
        // Define a single, shared JsonSerialiserOptions instance
        private static readonly JsonSerializerOptions JsonOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

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
            var responsePayload = JsonSerializer.Serialize(exceptionResponse, JsonOptions);

            // Set HTTP response details
            context.Response.StatusCode = status;
            context.Response.ContentType = "application/json";

            await context.Response.WriteAsync(responsePayload);
        }
    }
}