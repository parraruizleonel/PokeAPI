using PokeAPI.Repositories;
using PokeAPI.Services;
using Microsoft.EntityFrameworkCore;
using PokeAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
                     new MySqlServerVersion(new Version(8, 0, 25))));

// Registrar el repositorio
builder.Services.AddScoped<PokemonRepository>();

// Agregar el servicio de PokeAPI
builder.Services.AddHttpClient<PokeApiService>();

// Agregar controladores
builder.Services.AddControllers();

// Habilitar la exploración de endpoints y la documentación con Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuración del pipeline de solicitudes HTTP
if (app.Environment.IsDevelopment())
{
    // Habilitar Swagger y Swagger UI en desarrollo
    app.UseSwagger();
    app.UseSwaggerUI(); // Swagger UI estará disponible en http://localhost:5283/swagger
}

// Usar autorización (si la tienes configurada)
app.UseAuthorization();

// Mapear los controladores a las rutas
app.MapControllers();

// Ejecutar la aplicación
app.Run();
