using Microsoft.EntityFrameworkCore;

namespace Bugity.Api.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

    }
}