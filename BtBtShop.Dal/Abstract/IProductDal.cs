using System.Collections.Generic;
using BtBtShop.Entity.Entities;

namespace BtBtShop.Dal.Abstract
{
    public interface IProductDal
    {
        void Add(Product product);

        List<Product> GetAll();
    }
}