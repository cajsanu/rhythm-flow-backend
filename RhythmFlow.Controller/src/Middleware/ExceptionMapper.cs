using System.Net;

namespace RhythmFlow.Controller.src.Middleware
{
    // Static helper class for mapping exceptions to status codes and messages
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