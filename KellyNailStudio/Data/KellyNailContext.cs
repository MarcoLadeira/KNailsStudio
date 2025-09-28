using KellyNailStudio.Models;
using Microsoft.EntityFrameworkCore;

namespace KellyNailStudio.Data
{
    public class KellyNailContext : DbContext
    {

        public KellyNailContext(DbContextOptions<KellyNailContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Nails> Nails { get; set; }

    }
}
