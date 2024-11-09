using Azure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Data;
using ControleABordo.API.Models;

namespace ControleABordo.API.Context
{
    public class AppDbContext(DbContextOptions<AppDbContext> options)
        : DbContext(options)
    {

        public DbSet<Passageiro> Passageiros { get; set; }
        public DbSet<Voo> Voos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Passageiro>()
                .HasOne(p => p.Voo)
                .WithMany(c => c.Passageiros)
                .HasForeignKey(p => p.VooId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
