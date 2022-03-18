using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ClassManager : IClassService
    {
        IClassDal _classDal;

        public ClassManager(IClassDal classDal)
        {
            _classDal = classDal;
        }

        public IResult Add(Class classes)
        {
            _classDal.Add(classes);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Class classes)
        {
            _classDal.Delete(classes);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Class>> GetAll()
        {
            return new SuccessDataResult<List<Class>>(_classDal.GetAll(), Messages.Listed);
        }

        public IDataResult<Class> GetById(long classId)
        {
            return new SuccessDataResult<Class>(_classDal.Get(c => c.ClassId == classId), Messages.Get);
        }

        public IResult Update(Class classes)
        {
            _classDal.Update(classes);
            return new SuccessResult(Messages.Updated);
        }
    }
}
