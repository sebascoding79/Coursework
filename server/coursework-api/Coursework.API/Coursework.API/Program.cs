using Coursework.Core.Repositories;
using Coursework.Core.Services;
using Microsoft.EntityFrameworkCore;
using static Coursework.API.Extensions.HostEnvironmentExtensions;
using Coursework.Infrastructure.SQL.Models;
// Whenever a class is static you have to include it with "using static"

// -- Note: The startup and program files are combined now so everything in program
// appears first with var builder and everything in the startup file is second

var builder = WebApplication.CreateBuilder(args);
var services = builder.Services;
var env = builder.Environment;
var configuration = builder.Configuration;
// Add services to the container. Equivalent to: ConfigureServices() Method
// builder object of type: WebApplicationBuilder holds properties like Configuration and Services

services.AddControllers();
services.AddEndpointsApiExplorer();

var apiCorsPolicy = "ApiCorsPolicy";
services.AddCors(options =>
{
    options.AddPolicy(name: apiCorsPolicy,
        builder =>
        {
            builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
        });
});
services.AddSwaggerGen();

services.AddDbContext<CourseworkDBContext>(options => {
    options.UseSqlServer(configuration.GetConnectionString("Coursework"));
});

// We need this to be able to resolve the service and repository we created
services.AddScoped<GradesService>();
services.AddScoped<IGradesRepository, GradesRepository>();

// -- equivalent to the Configure() Method in startup file
// Used to configure the HTTP request pipeline so that means we are adding the middleware. 
// here we also define in what order the middleware components should be applied
// middleware = sits between application and server to handle http requests

var app = builder.Build();

app.UseCors(apiCorsPolicy);

// Configure the HTTP request pipeline.
if (app.Environment.IsLocal())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();