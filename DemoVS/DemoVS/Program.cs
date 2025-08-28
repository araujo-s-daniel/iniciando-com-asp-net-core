// Configuração do Builder

var builder = WebApplication.CreateBuilder(args);

// Configuração do Pipeline
// Middleware
// Services

// Configuração da App

var app = builder.Build();

// Configuração de Comportamentos da App

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () => "Isso é um teste!");

app.Run();
