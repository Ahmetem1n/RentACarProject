using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IIdentityInformationService
    {
        IDataResult<List<IdentityInformation>> GetAll();
        IDataResult<IdentityInformation> GetById(int identityId);
        IResult Add(IdentityInformation identity);
        IResult Update(IdentityInformation identity);
        IResult Delete(IdentityInformation identity);


    }
}
