namespace Evently.Api.Middleware;

internal static class MiddlewareExtensions
{
    public static IApplicationBuilder UseLogContextTraceLogging(this IApplicationBuilder app)
    {
        app.UseMiddleware<LogContextTraceLoggingMiddleware>();

        return app;
    }
}
