using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    [SecuredOperation("admin,employee")]
    public class RentalDetailManager : IRentalDetailService
    {
        IRentalDetailDal _rentalDetailDal;

        public RentalDetailManager(IRentalDetailDal rentalDetailDal)
        {
            _rentalDetailDal = rentalDetailDal;
        }

        public IResult Add(RentalDetail rentalDetail)
        {
            _rentalDetailDal.Add(rentalDetail);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(RentalDetail rentalDetail)
        {
            _rentalDetailDal.Delete(rentalDetail);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<RentalDetail>> GetAll()
        {
            return new SuccessDataResult<List<RentalDetail>>(_rentalDetailDal.GetAll(), Messages.Listed);
        }

        public IDataResult<RentalDetail> GetById(long rentalId)
        {
            return new SuccessDataResult<RentalDetail>(_rentalDetailDal.Get(r => r.RentalId == rentalId), Messages.Get);
        }

        public IResult Update(RentalDetail rentalDetail)
        {
            _rentalDetailDal.Update(rentalDetail);
            return new SuccessResult(Messages.Updated);
        }
    }
}
