using KalkulatorCijeneStrujeCore.Models.MojeKlase;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace KalkulatorCijeneStrujeCore.Data
{
    public class MojContext : DbContext
    {
        public MojContext(DbContextOptions<MojContext> options) : base(options)
        {
        }
        public DbSet<Rezultati> Izvijestaji { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Rezultati>()
                .ToTable("Izvijestaji")
                ;
        }
    }
}
  