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
    public class GearManager : IGearService
    {
        IGearDal _gearDal;

        public GearManager(IGearDal gearDal)
        {
            _gearDal = gearDal;
        }

        [SecuredOperation("Yönetici,Çalışan")]
        public IResult Add(Gear gear)
        {
            _gearDal.Add(gear);
            return new SuccessResult(Messages.Added);
        }

        [SecuredOperation("Yönetici,Çalışan")]
        public IResult Delete(Gear gear)
        {
            _gearDal.Delete(gear);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Gear>> GetAll()
        {
            return new SuccessDataResult<List<Gear>>(_gearDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Gear> GetById(long gearId)
        {
            return new SuccessDataResult<Gear>(_gearDal.Get(g => g.GearId == gearId), Messages.Get);
        }

        [SecuredOperation("Yönetici,Çalışan")]
        public IResult Update(Gear gear)
        {
            _gearDal.Update(gear);
            return new SuccessResult(Messages.Updated);
        }
    }
}
