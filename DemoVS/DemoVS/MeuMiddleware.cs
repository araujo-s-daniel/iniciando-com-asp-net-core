using Serilog;
using System.Diagnostics;

namespace DemoVS
{
    public class TemplateMiddleware
    {
        private readonly RequestDelegate _next;
        public TemplateMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            // Lógica antes de chamar o próximo middleware
            await _next(context);
            // Lógica após chamar o próximo middleware
        }
    }

    public class LogTempoMiddleware
    {
        private readonly RequestDelegate _next;
        public LogTempoMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            // Lógica antes de chamar o próximo middleware
            var sw = Stopwatch.StartNew();

            await _next(context);

            // Lógica após chamar o próximo middleware
            sw.Stop();
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
            Log.Information($"A execução demorou: {sw.ElapsedMilliseconds} ms ({sw.Elapsed.TotalSeconds}) segundos");
        }
    }
}
