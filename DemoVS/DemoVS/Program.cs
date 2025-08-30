using DemoVS;
using Serilog;

// Configuração do Builder

var builder = WebApplication.CreateBuilder(args);

// Configuração do Pipeline

builder.AddSerilog();
builder.Services.AddControllersWithViews();

// Middleware
// Services

// Configuração da App

var app = builder.Build();

// Configuração de Comportamentos da App

app.UseLogTempo();

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () =>
{
    Thread.Sleep(1500);
    return "Teste 2";
});

app.Run();
