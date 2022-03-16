using Business.Abstract;
using Business.Constants;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserRoleManager : IUserRoleService
    {
        IUserRoleDal _userRoleDal;

        public UserRoleManager(IUserRoleDal userRoleDal)
        {
            _userRoleDal = userRoleDal;
        }

        public IResult Add(UserRole userRole)
        {
            _userRoleDal.Add(userRole);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(UserRole userRole)
        {
            _userRoleDal.Delete(userRole);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<UserRole>> GetAll()
        {
            return new SuccessDataResult<List<UserRole>>(_userRoleDal.GetAll(), Messages.Listed);
        }

        public IDataResult<UserRole> GetById(int roleId)
        {
            return new SuccessDataResult<UserRole>(_userRoleDal.Get(u => u.RoleId == roleId), Messages.Get);
        }

        public IResult Update(UserRole userRole)
        {
            _userRoleDal.Update(userRole);
            return new SuccessResult(Messages.Updated);
        }
    }
}
