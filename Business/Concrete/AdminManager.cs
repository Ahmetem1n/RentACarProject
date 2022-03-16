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
    public class AdminManager : IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public IResult Add(Car admin)
        {
            _adminDal.Add(admin);
            return new SuccessResult(Messages.Added);
        }

        public IResult Add(Car admin)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Car admin)
        {
            _adminDal.Delete(admin);
            return new SuccessResult(Messages.Deleted);
        }

        public IResult Delete(Car admin)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_adminDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Car> GetById(int adminId)
        {
            return new SuccessDataResult<Car>(_adminDal.Get(a => a.AdminId == adminId), Messages.Get);
        }

        public IResult Update(Car admin)
        {
            _adminDal.Update(admin);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Update(Car admin)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Car>> IAdminService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Car> IAdminService.GetById(int adminId)
        {
            throw new NotImplementedException();
        }
    }
}
