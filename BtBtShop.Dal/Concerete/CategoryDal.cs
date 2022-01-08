using BtBtShop.Dal.Abstract;
using BtBtShop.Dal.DbContexts;
using BtBtShop.Entity.Entities;

namespace BtBtShop.Dal.Concerete
{
    public class CategoryDal : ICategoryDal
    {
        private readonly BtBtShopDbContext _dbContext;

        public CategoryDal(BtBtShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Category category)
        {
            _dbContext.Categories.Add(category);
        }
    }
}