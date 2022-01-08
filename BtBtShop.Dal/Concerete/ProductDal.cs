using System.Collections.Generic;
using System.Linq;
using BtBtShop.Dal.Abstract;
using BtBtShop.Dal.DbContexts;
using BtBtShop.Entity.Entities;

namespace BtBtShop.Dal.Concerete
{
    public class ProductDal : IProductDal
    {
        private readonly BtBtShopDbContext _dbContext;

        public ProductDal(BtBtShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Add(Product product)
        {
            _dbContext.Products.Add(product);
        }

        public List<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }
    }
}