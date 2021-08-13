using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiZodiacSigns.Entities;

namespace ApiZodiacSigns.Persistence
{
    public class ZodiacSignDbContext : DbContext
    {
        public DbSet<Sign> Signs { get; set; }
        public DbSet<Element> Elements { get; set; }
        public DbSet<Planet> Planets { get; set; }

        public ZodiacSignDbContext(DbContextOptions<ZodiacSignDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sign>().HasKey(s => s.Id);

            modelBuilder.Entity<Sign>()
                .HasOne(s => s.Element)
                .WithMany(e => e.Signs)
                .HasForeignKey(s => s.IdElement)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Sign>()
                .HasOne(s => s.Planet)
                .WithMany(p => p.Signs)
                .HasForeignKey(s => s.IdPlanet)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
