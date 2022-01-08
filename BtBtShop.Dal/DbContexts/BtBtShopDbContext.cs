using BtBtShop.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace BtBtShop.Dal.DbContexts
{
    public class BtBtShopDbContext : DbContext
    {
        public BtBtShopDbContext(DbContextOptions<BtBtShopDbContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}