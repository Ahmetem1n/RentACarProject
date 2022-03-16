using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPhoneNumberService
    {
        IDataResult<List<PhoneNumber>> GetAll();
        IDataResult<PhoneNumber> GetById(int phoneId);
        IResult Add(PhoneNumber phone);
        IResult Update(PhoneNumber phone);
        IResult Delete(PhoneNumber phone);

    }
}
