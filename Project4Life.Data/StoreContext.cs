using Project4Life.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Project4Life.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options)
            : base(options)
        { }

        public DbSet<Item> Items { get; set; }
    }
}