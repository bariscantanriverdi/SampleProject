using System.Collections.Generic;
using System.Threading.Tasks;
using BtBtShop.Dal.Abstract;
using BtBtShop.Entity.Entities;

namespace BtBtShop.Business.Concrete
{
    public class CategoryService
    {
        private readonly IBaseDal<Category> _categoryDal;

        public CategoryService(IBaseDal<Category> categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public Task<List<Category>> GetAll()
        {
            return _categoryDal.GetAllAsync();
        }
    }
}