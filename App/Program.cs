using Microsoft.AspNetCore.Builder;
using Scalar.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// Creamos el constructor
var builder = WebApplication.CreateBuilder(args);

// Agregamos los servicios
builder.Services.AddOpenApi();
builder.Services.AddControllers();

// Creamos la App
var app = builder.Build();

if( app.Environment.IsDevelopment()) // condicion para saber si lo estamos ejecutando
{
    app.MapOpenApi();
    app.MapScalarApiReference();
}

// configuracion de la app
app.UseAuthorization();
app.UseHttpsRedirection();
app.MapControllers(); // mapeo de los controladores.

// Inicando la app.
app.Run();