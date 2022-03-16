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
        IResult Add(PhoneNumber phoneNumber);
        IResult Update(PhoneNumber phoneNumber);
        IResult Delete(PhoneNumber phoneNumber);

    }
}
