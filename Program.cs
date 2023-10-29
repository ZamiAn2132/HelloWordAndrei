using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Configure the application to run as a Windows Service
builder.Host.UseWindowsService();

// Add this line to configure the application to listen on all network interfaces
builder.WebHost.ConfigureKestrel(serverOptions => serverOptions.ListenAnyIP(5000));

var app = builder.Build();

app.MapGet("/", () => "Hello World! This is the main page.");

app.MapGet("/andrei", () => "Hello Andrei! Welcome to your web app.");

app.MapGet("/test", () => "This is a test endpoint. Everything seems to be working!");

app.MapGet("/greet/{name}", (string name) => $"Hello {name}, nice to meet you!");

app.Run();
