using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class TiendaContext:DbContext
    {
        public DbSet<Producto> Productos { get; set; }
   
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer("Data Source = DESKTOP-BCE0IN6; Initial Catalog = Tienda; Integrated Security = true;");
        }
    }
}
