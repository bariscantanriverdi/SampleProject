using System.Collections.Generic;
using BtBtShop.Business.Abstract;
using BtBtShop.Dal.Abstract;
using BtBtShop.Entity.Entities;

namespace BtBtShop.Business.Concerete
{
    public class ProductService : IProductService
    {
        private readonly IProductDal _productDal;
        
        public ProductService(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetProducts()
        {
            // Loglama
            var products = _productDal.GetAll();

            return products;
        }
    }
}