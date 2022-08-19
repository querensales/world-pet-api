using Microsoft.EntityFrameworkCore;
using WorldPetApi.Entities;

namespace WorldPetApi.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Especie>  Name { get; set; }
        
        

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=app.db;Cache=Shared");
        }
    }
}