using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BtBtShop.Dal.Abstract;
using BtBtShop.Dal.DbContexts;
using BtBtShop.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace BtBtShop.Dal.Concrete
{
    public class BaseDal<TEntity> : IBaseDal<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly BtBtShopDbContext _dbContext;

        public BaseDal(
            BtBtShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(
            TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public List<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public async Task AddAsync(
            TEntity entity)
        {
            await _dbContext.Set<TEntity>().AddAsync(entity);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}