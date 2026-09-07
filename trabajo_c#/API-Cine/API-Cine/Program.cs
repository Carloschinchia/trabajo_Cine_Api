using API_Cine.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Agregar Controllers
builder.Services.AddControllers();

// Conexión con SQL Server
builder.Services.AddDbContext<DbCineContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("Cineconexion")
    ));

// OpenAPI
builder.Services.AddOpenApi();

var app = builder.Build();

// Configuración del entorno
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Activar Controllers
app.MapControllers();   

app.Run();