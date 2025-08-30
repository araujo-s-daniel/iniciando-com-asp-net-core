// Configura��o do Builder

using DemoVS;

var builder = WebApplication.CreateBuilder(args);

// Configura��o do Pipeline

// Middleware
// Services

// Configura��o da App

var app = builder.Build();

// Configura��o de Comportamentos da App

app.UseMiddleware<LogTempoMiddleware>();

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () =>
{
    Thread.Sleep(1500);
    return "Teste 2";
});

app.Run();
