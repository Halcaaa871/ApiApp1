using Microsoft.EntityFrameworkCore;
using ApiApp1.Models;

namespace ApiApp1.Data
{
    public class FishDbContext : DbContext
    {
        public FishDbContext(DbContextOptions<FishDbContext> options) : base(options) { }

        public DbSet<FishCatch>FishCatchs { get; set; }
    }
}
