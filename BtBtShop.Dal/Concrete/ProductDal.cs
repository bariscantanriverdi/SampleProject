using System.Collections.Generic;
using System.Linq;
using BtBtShop.Dal.Abstract;
using BtBtShop.Dal.DbContexts;
using BtBtShop.Entity.Entities;

namespace BtBtShop.Dal.Concrete
{
    public class ProductDal : IProductDal
    {
        private readonly BtBtShopDbContext _dbContext;

        public ProductDal(BtBtShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //CRUD operations
        // Create, Read, Update, Delete
        
        
        
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