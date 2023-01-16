using CalendarFormula1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace CalendarFormula1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)


        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Piloti_Cursa>().HasKey(pc => new
            {
                pc.PilotiId,
                pc.CursaId
            });

            modelBuilder.Entity<Piloti_Cursa>().HasOne(c => c.Cursa).WithMany(pc => pc.Pilotii_Cursaa).HasForeignKey(pc => pc.CursaId);
            modelBuilder.Entity<Piloti_Cursa>().HasOne(c => c.Piloti).WithMany(pc => pc.Pilotii_Cursaa).HasForeignKey(pc => pc.PilotiId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Cursa> Cursaa { get; set; }
        public DbSet<Piloti> Pilotii { get; set; }
        public DbSet<Tara> Taraa { get; set; }

        public DbSet<Piloti_Cursa> Pilotii_Cursaa { get; set; }
    }
}