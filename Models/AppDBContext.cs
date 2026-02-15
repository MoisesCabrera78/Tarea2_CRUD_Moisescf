using Microsoft.EntityFrameworkCore;

namespace WebApplication1_moises.Models
{
    // El ": DbContext" es lo que le faltaba para que Program.cs no de error
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Producto> Productos { get; set; }
    }
}