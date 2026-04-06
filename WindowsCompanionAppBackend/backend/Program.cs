using System.Windows.Input;
using backend.Controllers;
using backend.Core.Abstract;
using backend.Core.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Add SignalR: A system for real-time, bidirectional communication between clients and servers.
builder.Services.AddSignalR();

builder.Services.AddScoped<ICommands, CommandManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapHub<CommandHub>("/hubs/commands");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();