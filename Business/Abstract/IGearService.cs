using Core.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IGearService
    {
        IDataResult<List<Gear>> GetAll();
        IDataResult<Gear> GetById(int gearId);
        IResult Add(Gear gear);
        IResult Update(Gear gear);
        IResult Delete(Gear gear);


    }
}
