using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtBtShop.Dal.DbContexts
{
    class BtBtDbContextDesignTimeFactory : IDesignTimeDbContextFactory<BtBtShopDbContext>
    {
        public BtBtShopDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BtBtShopDbContext>();
            optionsBuilder.UseSqlServer(@"Data Source=Localhost;Initial Catalog=BtBtShop;Trusted_Connection=Yes");
            return new BtBtShopDbContext(optionsBuilder.Options);
        }
    }
}
