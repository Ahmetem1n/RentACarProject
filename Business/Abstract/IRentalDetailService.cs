using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalDetailService
    {
        IDataResult<List<RentalDetail>> GetAll();
        IDataResult<RentalDetail> GetById(int rentalId);
        IResult Add(RentalDetail rental);
        IResult Update(RentalDetail rental);
        IResult Delete(RentalDetail rental);

    }
}
