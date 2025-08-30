// Configuração do Builder

using DemoVS;

var builder = WebApplication.CreateBuilder(args);

// Configuração do Pipeline

// Middleware
// Services

// Configuração da App

var app = builder.Build();

// Configuração de Comportamentos da App

app.UseMiddleware<LogTempoMiddleware>();

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () =>
{
    Thread.Sleep(1500);
    return "Teste 2";
});

app.Run();
