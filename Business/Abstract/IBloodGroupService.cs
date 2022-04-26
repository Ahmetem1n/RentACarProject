
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IBloodGroupService
    {
        IDataResult<List<BloodGroup>> GetAll();
        IDataResult<BloodGroup> GetById(long bloodGroupId);
        IResult Add(BloodGroup bloodGroup);
        IResult Update(BloodGroup bloodGroup);
        IResult Delete(BloodGroup bloodGroup);

    }
}
