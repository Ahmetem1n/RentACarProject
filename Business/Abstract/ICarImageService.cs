﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(long imageId);
        IResult Add(CarImage carImage);
        IResult Update(CarImage carImage);
        IResult Delete(CarImage carImage);


    }
}
