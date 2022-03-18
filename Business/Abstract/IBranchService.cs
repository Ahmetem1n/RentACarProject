﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBranchService
    {
        IDataResult<List<Branch>> GetAll();
        IDataResult<Branch> GetById(long branchId);
        IResult Add(Branch branch);
        IResult Update(Branch branch);
        IResult Delete(Branch branch);


    }
}
