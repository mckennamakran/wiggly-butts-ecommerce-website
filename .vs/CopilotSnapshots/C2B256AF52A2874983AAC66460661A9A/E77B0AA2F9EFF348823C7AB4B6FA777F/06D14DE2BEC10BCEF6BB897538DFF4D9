namespace WigglyButts.Data
{
    using Microsoft.EntityFrameworkCore;
    using WigglyButts.Models;

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Product> Products => Set<Product>();
    }
}
