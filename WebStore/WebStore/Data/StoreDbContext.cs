using Microsoft.EntityFrameworkCore;
using WebStore.Data.Entities;

namespace WebStore.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options)
            :base(options) { }

        public DbSet<CategoryEntity> Categories { get; set; }
    }
}
