using Microsoft.EntityFrameworkCore; 
// Utilizamos Entity Framework Core para trabajar con la base de datos

using MotoRepAPI.Models;
// Importamos el modelo Contacto para poder mapearlo a la base de datos

namespace MotoRepAPI.Data
{
    public class MotoRepDbContext : DbContext 
    // Definimos la clase MotoRepDbContext que hereda de DbContext
    {
        public MotoRepDbContext(DbContextOptions<MotoRepDbContext> options) : base(options)
        // Llamamos al constructor de la clase base DbContext con las opciones proporcionadas
        {
        }
        public DbSet<Contacto> Contactos { get; set; } 
        // Representa la tabla de contactos en la base de datos
    }
    
}
