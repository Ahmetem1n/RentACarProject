﻿using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFuelService
    {
        IDataResult<List<Fuel>> GetAll();
        IDataResult<Fuel> GetById(long fuelId);
        IResult Add(Fuel fuel);
        IResult Update(Fuel fuel);
        IResult Delete(Fuel fuel);


    }
}
