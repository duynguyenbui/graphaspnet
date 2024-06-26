var builder = WebApplication.CreateBuilder(args);

builder.AddApplicationServices();

var app = builder.Build();

// Configure Middlewares

app.UseSwagger();
app.UseSwaggerUI();


app.UseMiddleware<ErrorHandlerMiddleware>();
app.MapGraphDatabaseApi();
app.MapGet("/", () => "Hello, world!");

app.Run();