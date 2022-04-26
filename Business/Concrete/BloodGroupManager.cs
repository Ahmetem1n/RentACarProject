using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BloodGroupManager: IBloodGroupService
    {
        IBloodGroupDal _bloodGroupDal;

        public BloodGroupManager(IBloodGroupDal bloodGroupDal)
        {
            _bloodGroupDal = bloodGroupDal;
        }

        [SecuredOperation("admin,employee")]
        //[ValidationAspect(typeof(BloodGroupValidator))]
        public IResult Add(BloodGroup bloodGroup)
        {
            _bloodGroupDal.Add(bloodGroup);
            return new SuccessResult(Messages.Added);
        }

        [SecuredOperation("admin,employee")]
        public IResult Delete(BloodGroup bloodGroup)
        {
            _bloodGroupDal.Delete(bloodGroup);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<BloodGroup>> GetAll()
        {
            return new SuccessDataResult<List<BloodGroup>>(_bloodGroupDal.GetAll(), Messages.Listed);
        }

        public IDataResult<BloodGroup> GetById(long bloodGroupId)
        {
            return new SuccessDataResult<BloodGroup>(_bloodGroupDal.Get(b => b.BloodGroupId == bloodGroupId), Messages.Get);
        }

        [SecuredOperation("admin,employee")]
        public IResult Update(BloodGroup bloodGroup)
        {
            _bloodGroupDal.Update(bloodGroup);
            return new SuccessResult(Messages.Updated);
        }
    }
}
