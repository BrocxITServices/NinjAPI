using Microsoft.EntityFrameworkCore;
using NinjAPI.Models;
namespace NinjAPI.Data
{
    public class YourDbContext : DbContext
    {
        public YourDbContext(DbContextOptions<YourDbContext> options)
            : base(options)
        { }
        public DbSet<BaseEntity> BaseEntity { get; set; }
        public DbSet<Ninja> Ninjas { get; set; }
        public DbSet<Training> Trainings { get; set; }
    }
}
