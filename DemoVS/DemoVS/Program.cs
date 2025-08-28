// Configura��o do Builder

var builder = WebApplication.CreateBuilder(args);

// Configura��o do Pipeline
// Middleware
// Services

// Configura��o da App

var app = builder.Build();

// Configura��o de Comportamentos da App

app.MapGet("/", () => "Hello World!");
app.MapGet("/teste", () => "Isso � um teste!");

app.Run();
