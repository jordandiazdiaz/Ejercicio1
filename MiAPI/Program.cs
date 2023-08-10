using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MiAPI.Models; // Ajusta esto según la ubicación de tu ApplicationDbContext

var builder = WebApplication.CreateBuilder(args);

// Agrega servicios a la DI y configuración
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

// Crea y configura la aplicación
var app = builder.Build();

// Configuración de Swagger
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "MiAPI v1"));

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

