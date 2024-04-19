var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<AppDbContext>();

app.MapGet("v1/Film", (AppDbContext context) =>
{
    var film = context.Film.ToList();
    return Results.Ok(film);
});

app.Run();
