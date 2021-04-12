using Microsoft.EntityFrameworkCore;

namespace BackEnd.Model
{
    public class AplicationDbContext: DbContext
    {
        public DbSet<Pais> Paises { get; set; }

        public DbSet<Ciudad> Ciudades { get; set; }

        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base(options)
        {

        }
    }
}
