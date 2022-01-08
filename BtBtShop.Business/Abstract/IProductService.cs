using System.Collections.Generic;
using BtBtShop.Entity.Entities;

namespace BtBtShop.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}