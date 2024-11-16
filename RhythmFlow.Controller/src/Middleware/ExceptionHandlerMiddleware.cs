using System.Text.Json;
using Microsoft.AspNetCore.Http;

namespace RhythmFlow.Controller.src.Middleware
{
    public class ExceptionHandlerMiddleware : IMiddleware
    {
        // Define a single, shared JsonSerialiserOptions instance
        private static readonly JsonSerializerOptions JsonOptions = new ()
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

            // Customise response, for development purposes we can add <Details = exception.Message>
            var exceptionResponse = new
            {
                StatusCode = status,
                Message = message,
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