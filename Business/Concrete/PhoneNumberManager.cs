using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    [SecuredOperation("Yönetici,Çalışan")]
    public class PhoneNumberManager : IPhoneNumberService
    {
        IPhoneNumberDal _phoneNumberDal;

        public PhoneNumberManager(IPhoneNumberDal phoneNumberDal)
        {
            _phoneNumberDal = phoneNumberDal;
        }

        public IResult Add(PhoneNumber phoneNumber)
        {
            _phoneNumberDal.Add(phoneNumber);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(PhoneNumber phoneNumber)
        {
            _phoneNumberDal.Delete(phoneNumber);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<PhoneNumber>> GetAll()
        {
            return new SuccessDataResult<List<PhoneNumber>>(_phoneNumberDal.GetAll(), Messages.Listed);
        }

        public IDataResult<PhoneNumber> GetById(long phoneId)
        {
            return new SuccessDataResult<PhoneNumber>(_phoneNumberDal.Get(p => p.PhoneId == phoneId), Messages.Get);
        }

        public IDataResult<List<PhoneNumber>> GetByUserPhoneNumbers(long userId)
        {
            return new SuccessDataResult<List<PhoneNumber>>(_phoneNumberDal.GetAll(p => p.UserId == userId));
        }

        public IDataResult<List<PhoneNumberDetailDto>> GetPhoneNumberDetails()
        {
            return new SuccessDataResult<List<PhoneNumberDetailDto>>(_phoneNumberDal.GetPhoneNumberDetails(), Messages.Listed);
        }

        public IResult Update(PhoneNumber phoneNumber)
        {
            _phoneNumberDal.Update(phoneNumber);
            return new SuccessResult(Messages.Updated);
        }
    }
}
