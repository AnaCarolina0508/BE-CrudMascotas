using Microsoft.EntityFrameworkCore;

namespace BE_CrudMascotas.Models
{
    public class AplicationBbContext : DbContext
    {
        public AplicationBbContext(DbContextOptions<AplicationBbContext> options) : base(options) 
        { 

        }  
        
        public DbSet<Mascota> Mascotas { get; set; }



    }
}
