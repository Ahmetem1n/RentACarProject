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
    public class CaseTypeManager : ICaseTypeService
    {
        ICaseTypeDal _caseTypeDal;

        public CaseTypeManager(ICaseTypeDal caseTypeDal)
        {
            _caseTypeDal = caseTypeDal;
        }

        public IResult Add(CaseType caseType)
        {
            _caseTypeDal.Add(caseType);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(CaseType caseType)
        {
            _caseTypeDal.Delete(caseType);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<CaseType>> GetAll()
        {
            return new SuccessDataResult<List<CaseType>>(_caseTypeDal.GetAll(), Messages.Listed);
        }

        public IDataResult<CaseType> GetById(int caseId)
        {
            return new SuccessDataResult<CaseType>(_caseTypeDal.Get(c => c.CaseId == caseId), Messages.Get);
        }

        public IResult Update(CaseType caseType)
        {
            _caseTypeDal.Update(caseType);
            return new SuccessResult(Messages.Updated);
        }
    }
}
