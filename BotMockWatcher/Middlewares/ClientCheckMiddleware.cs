using InfoCollector.Models;
using InfoCollector.Services;

namespace BotMockWatcher.Middlewares;

public class ClientCheckMiddleware(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;

    public async Task InvokeAsync(HttpContext context/*, IClientCheckService service*/)
    {
        var model = new RemoteConnectionInfo(
            context.Connection.RemoteIpAddress,
            context.Connection.RemotePort,
            context.Request.Headers,
            context.Request.Path);

        //await service.HandleConnectionInfo(model);

        await _next(context);
    }
}
