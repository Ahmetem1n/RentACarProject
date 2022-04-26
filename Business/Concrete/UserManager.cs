using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //[SecuredOperation("admin,employee")]
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
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<User>> GetByRoles(string claimName)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetByRoles(claimName), Messages.Listed);
        }

        public IDataResult<User> GetById(long userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == userId), Messages.Get);
        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        }

        public IDataResult<OperationClaim> GetClaim(User user)
        {
            return new SuccessDataResult<OperationClaim>(_userDal.GetClaim(user));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated);
        }
    }
}
