using System.Collections.Generic;
using BtBtShop.Business.Abstract;
using BtBtShop.Dal.Abstract;
using BtBtShop.Entity.Entities;

namespace BtBtShop.Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IBaseDal<Product> _productDal;

        public ProductService(IBaseDal<Product> productDal)
        {
            _productDal = productDal;
        }
        
        // private readonly IProductDal _productDal;
        //
        // public ProductService(IProductDal productDal)
        // {
        //     _productDal = productDal;
        // }

        public List<Product> GetProducts()
        {
            // Loglama
            var products = _productDal.GetAll();

            return products;
        }
    }
}