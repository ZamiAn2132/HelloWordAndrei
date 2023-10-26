var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! This is the main page.");

app.MapGet("/andrei", () => "Hello Andrei! Welcome to your web app.");

app.MapGet("/test", () => "This is a test endpoint. Everything seems to be working!");

app.MapGet("/greet/{name}", (string name) => $"Hello {name}, nice to meet you!");

app.Run();
