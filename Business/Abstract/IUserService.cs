using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<UserDetailDto>> GetUserDetails();
        IDataResult<List<User>> GetByRoles(string claimName);
        IDataResult<User> GetById(long userId);
        IResult Add(User user);
        IResult Update(User user);
        IResult Delete(User user);
        IDataResult<OperationClaim> GetClaim(User user);
        IDataResult<User> GetByMail(string email);
    }
}
