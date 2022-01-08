using System.Collections.Generic;
using System.Threading.Tasks;
using BtBtShop.Business.Abstract;
using BtBtShop.Dal.Abstract;
using BtBtShop.Entity.Entities;

namespace BtBtShop.Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IBaseDal<User> _userDal;

        public UserService(
            IBaseDal<User> userDal)
        {
            _userDal = userDal;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await _userDal.GetAllAsync();
        }
    }
}