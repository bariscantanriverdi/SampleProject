using System.Collections.Generic;
using System.Threading.Tasks;

namespace BtBtShop.Dal.Abstract
{
    public interface IBaseDal<T>
    {
        void Add(T entity);

        List<T> GetAll();

        Task AddAsync(T entity);
        Task<List<T>> GetAllAsync();
        
        Task<T> GetByIdAsync(int id);
    }
    
}