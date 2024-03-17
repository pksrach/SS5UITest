using Microsoft.EntityFrameworkCore;

namespace SS5UITest.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        { 
        }

        public DbSet<Product> Product {  get; set; }
    }
}
