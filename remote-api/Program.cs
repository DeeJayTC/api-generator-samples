using System.Configuration;
using System.Reflection;
using Newtonsoft.Json;
using TCDev.ApiGenerator.Extension;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add API Generator and load data
await builder.Services.AddApiGeneratorServices(builder.Configuration, Assembly.GetExecutingAssembly());

var app = builder.Build();

// Automatically migrate changes
app.UseAutomaticApiMigrations();
app.UseHttpsRedirection();
app.UseApiGenerator();
app.MapControllers();

app.Run();
