using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserRoleService
    {
        IDataResult<List<UserRole>> GetAll();
        IDataResult<UserRole> GetById(long roleId);
        IResult Add(UserRole userRole);
        IResult Update(UserRole userRole);
        IResult Delete(UserRole userRole);


    }
}
