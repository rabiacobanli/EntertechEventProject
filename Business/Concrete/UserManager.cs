using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TAdd(User t)
        {
            _userDal.Add(t);
        }

        public void TDelete(User t)
        {
            _userDal.Delete(t);

        }

        public List<User> TGetAll()
        {
            return _userDal.GetAll();
        }

        public User TGetByID(int id)
        {
            return _userDal.Get(u => u.UserID == id);
        }

        public void TUpdate(User t)
        {
            _userDal.Update(t);

        }
    }
}
