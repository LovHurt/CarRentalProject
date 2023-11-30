using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.UsersAddedSuccessMessage);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            Console.WriteLine(Messages.UserDeleted);
            return new SuccessResult();
        }
        public IResult Delete(int userId)
        {
            var userToDelete = _userDal.Get(u => u.UserId == userId);

            if (userToDelete == null)
            {
                Console.WriteLine(Messages.UserNotFound);
                return new ErrorResult(Messages.UserNotFound);
            }

            _userDal.Delete(userToDelete);
            Console.WriteLine(Messages.UserDeleted);
            return new SuccessResult();
        }


        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetByUserId(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == userId));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult();
        }
    }
}
