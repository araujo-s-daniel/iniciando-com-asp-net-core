using DemoVS;
using Serilog;

// Configura��o do Builder

var builder = WebApplication.CreateBuilder(args);

// Configura��o do Pipeline

builder.AddSerilog();
builder.Services.AddControllersWithViews();

// Middleware
// Services

// Configura��o da App

var app = builder.Build();

// Configura��o de Comportamentos da App

app.UseLogTempo();

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () =>
{
    Thread.Sleep(1500);
    return "Teste 2";
});

app.Run();
