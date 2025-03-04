using Microsoft.AspNetCore.Http.Extensions;

namespace OneToMany.Middleware
{
    public static class CustomExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseCustomExceptionHandling(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CustomExceptionMiddleware>();
        }
    }

    public class CustomExceptionMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ILogger<CustomExceptionMiddleware> _logger;

        // Constructor accepts the next middleware in the pipeline and the logger
        public CustomExceptionMiddleware(RequestDelegate next, ILogger<CustomExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        // InvokeAsync method where the exception handling takes place
        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                // Call the next middleware in the pipeline
                await _next(context);
            }
            catch (Exception ex)
            {
                // Log the exception
                //_logger.LogError(ex, "An unexpected error occurred");

                // Handle the exception by returning a custom error response
                await HandleExceptionAsync(context, ex);
            }
        }

        // Method to create a custom error response
        private Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            // Set the status code for the response (e.g., Internal Server Error)
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            // Specify the content type of the response
            context.Response.ContentType = "application/json";

            var a = context.Request.Path;

            // Customize the error response body
            var errorResponse = new
            {
                message = "An unexpected error occurred. Please try again later.",
                errorDetails = exception.Message // This can be detailed in development mode
                ,Name="Akhileswar implemented custom exception handler",
                path= a
            };

            // Write the response body
            return context.Response.WriteAsJsonAsync(errorResponse);
        }

    }
}
