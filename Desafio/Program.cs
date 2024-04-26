using Microsoft.AspNetCore.Rewrite;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Desafio Balta May the Fourth Backend",
        Version = "v1",
        Description = "",
        Contact = new OpenApiContact
        {
            Name = "Humberto, Fábio, Mário, Rafael, Vagner",
            Url = new Uri("https://www.google.com.br")
        }
    });
});
builder.Services.AddApiVersioning();

builder.Services.AddScoped<IFilmesService, FilmesService>();
builder.Services.AddScoped<INavesEstelaresService, NavesEstelaresService>();
builder.Services.AddScoped<IPersonagensService, PersonagensService>();
builder.Services.AddScoped<IPlanetasService, PlanetasService>();
builder.Services.AddScoped<IVeiculosService, VeiculosService>();

builder.Services.AddScoped<IFilmesRepository, FilmesRepository>();
builder.Services.AddScoped<INavesEstelaresRepository, NavesEstelaresRepository>();
builder.Services.AddScoped<IPersonagensRepository, PersonagensRepository>();
builder.Services.AddScoped<IPlanetasRepository, PlanetasRepository>();
builder.Services.AddScoped<IVeiculosRepository, VeiculosRepository>();




var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();
app.MapControllerRoute("DefaultApi", "{controller=values}/v{version=apiVersion}/{id?}");


app.Run();
