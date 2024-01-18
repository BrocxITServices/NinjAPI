using Microsoft.EntityFrameworkCore;
using NinjAPI.Models;
namespace NinjAPI.Data
{
    public class GymContext : DbContext
    {
        public GymContext(DbContextOptions<GymContext> options)
            : base(options)
        { }
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Training> Trainings { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Ninja>().Property(c => c.NinjaId).HasDefaultValueSql("NEWID()");
            mb.Entity<Training>().Property(c => c.TrainingId).HasDefaultValueSql("NEWID()");
        }
    }
}

