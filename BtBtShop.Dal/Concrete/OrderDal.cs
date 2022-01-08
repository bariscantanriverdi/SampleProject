using BtBtShop.Dal.Abstract;
using BtBtShop.Dal.DbContexts;
using BtBtShop.Entity.Entities;

namespace BtBtShop.Dal.Concrete
{
    public class OrderDal : IOrderDal
    {
        private readonly BtBtShopDbContext _dbContext;

        public OrderDal(BtBtShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void Add(Order order)
        {
            _dbContext.Orders.Add(order);
        }
    }
}