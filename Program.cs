using Microsoft.EntityFrameworkCore;
using PokeAPI.Data;
using PokeAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Agregar HttpClient para que pueda ser inyectado en los servicios
builder.Services.AddHttpClient<PokeApiService>();

// Agregar el contexto de base de datos
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                     new MySqlServerVersion(new Version(8, 0, 25))));

builder.Services.AddScoped<PokeApiService>();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configurar el pipeline de solicitudes HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
