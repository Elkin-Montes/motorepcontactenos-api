using Microsoft.EntityFrameworkCore; 
// Importamos el espacio de nombres para trabajar con Entity Framework Core

using MotoRepAPI.Data; 
// Importamos el espacio de nombres donde se encuentra la clase MotoRepDbContext

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configurar DbContext con Azure SQL
builder.Services.AddDbContext<MotoRepDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AzureSQL")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configuración de HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
