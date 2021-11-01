using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class TiendaContext:DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Talle> Talles { get; set; }
        public DbSet<User> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source = DESKTOP-BCE0IN6; Initial Catalog = Tienda; Integrated Security = true;");
        }
    }
}
