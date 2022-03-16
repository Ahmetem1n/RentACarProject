using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDrivingInformationService
    {
        IDataResult<List<DrivingInformation>> GetAll();
        IDataResult<DrivingInformation> GetById(int drivingId);
        IResult Add(DrivingInformation drivingInformation);
        IResult Update(DrivingInformation drivingInformation);
        IResult Delete(DrivingInformation drivingInformation);


    }
}
