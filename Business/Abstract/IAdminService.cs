using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAdminService
    {
        IDataResult<List<Admin>> GetAll();
        IDataResult<Admin> GetById(long adminId);
        IResult Add(Admin admin);
        IResult Update(Admin admin);
        IResult Delete(Admin admin);
    }
}
