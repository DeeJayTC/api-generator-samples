using System.Configuration;
using System.Reflection;
using Newtonsoft.Json;
using TCDev.APIGenerator;
using TCDev.APIGenerator.Extension;
using TCDev.APIGenerator.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Add API Generator and load data
builder.Services.AddApiGeneratorServices()
                .AddSwagger(true)
                .AddDataContextSQL()
                .AddOData()
                .AddAssemblyWithOData(Assembly.GetExecutingAssembly());

    
    
var app = builder.Build();

// Automatically migrate changes
app.UseAutomaticApiMigrations();
app.UseHttpsRedirection();
app.UseApiGenerator();
app.MapControllers();

app.Run();
