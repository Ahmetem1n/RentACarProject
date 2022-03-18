using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(long carId);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IDataResult<List<Car>> getCarsByColorId(long colorId);
        IDataResult<List<Car>> GetCarsByBrandId(long brandId);
        IDataResult<List<CarDetailDto>> GetCarDetails();

    }
}
