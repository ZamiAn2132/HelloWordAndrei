using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// I set the application to run as a Windows Service in order later to be able to automatically start the app
builder.Host.UseWindowsService();

// I have added this line to configure ("force") the application to listen on all network interfaces
builder.WebHost.ConfigureKestrel(serverOptions => serverOptions.ListenAnyIP(5000));

var app = builder.Build();

//  GET endpoint at the root ("/") of the application
app.MapGet("/", () => "Hello World! This is the main page.");

// a GET endpoint at "/andrei 
app.MapGet("/andrei", () => "Hello Andrei! Welcome to your web app.");

app.MapGet("/test", () => "This is a test endpoint. Everything seems to be working!");

app.MapGet("/greet/{name}", (string name) => $"Hello {name}, nice to meet you!");

//Start the application and listen for incoming HTTP requests
app.Run();
