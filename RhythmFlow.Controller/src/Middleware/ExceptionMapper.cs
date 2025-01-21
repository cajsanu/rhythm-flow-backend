using System.Net;

namespace RhythmFlow.Controller.src.Middleware
{
    // Static helper class for mapping exceptions to status codes and messages
    public static class ExceptionMapper
    {
        private static readonly Dictionary<Type, (int StatusCode, string Message)> ExceptionMappings = new()
    {
        { typeof(InvalidOperationException), ((int)HttpStatusCode.BadRequest, "The operation is not valid.") },
        { typeof(KeyNotFoundException), ((int)HttpStatusCode.NotFound, "The requested resource was not found.") },
        { typeof(InvalidDataException), ((int)HttpStatusCode.BadRequest, "The data provided is invalid.") },
        { typeof(UnauthorizedAccessException), ((int)HttpStatusCode.Unauthorized, "You are not authorized to access this resource.") },
        { typeof(NotImplementedException), ((int)HttpStatusCode.NotImplemented, "This feature is not yet implemented.") },
        { typeof(ArgumentException), ((int)HttpStatusCode.BadRequest, "The argument provided is invalid.") },
        { typeof(FormatException), ((int)HttpStatusCode.BadRequest, "The format of the data provided is invalid.") },
        { typeof(NotSupportedException), ((int)HttpStatusCode.NotImplemented, "This operation is not supported.") },
        { typeof(OutOfMemoryException), ((int)HttpStatusCode.InternalServerError, "The system has run out of memory.") },
        { typeof(IndexOutOfRangeException), ((int)HttpStatusCode.BadRequest, "The index is out of range.") },
        { typeof(NullReferenceException), ((int)HttpStatusCode.BadRequest, "The object is null.") },
        { typeof(ArgumentNullException), ((int)HttpStatusCode.BadRequest, "The argument provided is null.") },
        { typeof(ArgumentOutOfRangeException), ((int)HttpStatusCode.BadRequest, "The argument is out of range.") },
        { typeof(BCrypt.Net.SaltParseException), ((int)HttpStatusCode.InternalServerError, "An error occurred while parsing the salt.") },
        { typeof(Exception), ((int)HttpStatusCode.InternalServerError, "An unexpected error occurred. Please try again later.") }
    };

        public static (int StatusCode, string Message) MapException(Exception exception)
        {
            return ExceptionMappings.TryGetValue(exception.GetType(), out var result)
                ? (result.StatusCode, exception.Message ?? result.Message) // Use the exception message thrown by the application if available, otherwise use the default message
                : ((int)HttpStatusCode.InternalServerError, "An unexpected error occurred. Please try again later.");
        }
    }
}