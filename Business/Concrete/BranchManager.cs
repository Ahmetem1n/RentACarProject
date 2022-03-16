using Business.Abstract;
using Business.Constants;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BranchManager : IBranchService
    {
        IBranchDal _branchDal;

        public BranchManager(IBranchDal branchDal)
        {
            _branchDal = branchDal;
        }

        public IResult Add(Branch branch)
        {
            _branchDal.Add(branch);
            return new SuccessResult(Messages.Added);
        }

        public IResult Add(Branch branch)
        {
            throw new NotImplementedException();
        }

        public IResult Add(Branch branch)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Branch branch)
        {
            _branchDal.Delete(branch);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Delete(Car branch)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Branch>> GetAll()
        {
            return new SuccessDataResult<List<Branch>>(_branchDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Branch> GetById(int branchId)
        {
            return new SuccessDataResult<Branch>(_branchDal.Get(b => b.BranchId == branchId), Messages.Get);
        }

        public IResult Update(Branch branch)
        {
            _branchDal.Update(branch);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Update(Car branch)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> IBranchService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Car> IBranchService.GetById(int branchId)
        {
            throw new NotImplementedException();
        }
    }
}
