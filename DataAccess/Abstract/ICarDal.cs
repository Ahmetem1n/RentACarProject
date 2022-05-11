using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        List<CarDetailDto> GetByUsable(DateTime rentDate,DateTime returnDate, long branchId);
        List<CarDetailDto> GetCarDetails();
    }
}
