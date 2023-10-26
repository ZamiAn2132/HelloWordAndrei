var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World Andrei  cu CsI!MAi facem un mic test");

app.Run();
