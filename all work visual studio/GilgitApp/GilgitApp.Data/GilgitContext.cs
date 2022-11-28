using GilgitApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace GilgitApp.Data
{
    public class GilgitContext : DbContext
    {
        public DbSet<Gilgit> gilgities { get; set; }
        public DbSet<quotes> quo { get; set; }

        public GilgitContext(DbContextOptions<GilgitContext> options) : base(options)
        {
        
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("");
        }
    }

}
