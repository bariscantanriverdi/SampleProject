using System.Collections.Generic;
using System.Threading.Tasks;
using BtBtShop.Entity.Entities;

namespace BtBtShop.Business.Abstract
{
    public interface IUserService
    {
        Task<List<User>> GetAllUsers();
    }
}