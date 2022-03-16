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
    public class IdentityInformationManager : IIdentityInformationService
    {
        IIdentityInformationDal _identityInformationDal;

        public IdentityInformationManager(IIdentityInformationDal identityInformationDal)
        {
            _identityInformationDal = identityInformationDal;
        }

        public IResult Add(IdentityInformation identityInformation)
        {
            _identityInformationDal.Add(identityInformation);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(IdentityInformation identityInformation)
        {
            _identityInformationDal.Delete(identityInformation);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<IdentityInformation>> GetAll()
        {
            return new SuccessDataResult<List<IdentityInformation>>(_identityInformationDal.GetAll(), Messages.Listed);
        }

        public IDataResult<IdentityInformation> GetById(int identityId)
        {
            return new SuccessDataResult<IdentityInformation>(_identityInformationDal.Get(i => i.IdentityId == identityId), Messages.Get);
        }

        public IResult Update(IdentityInformation identityInformation)
        {
            _identityInformationDal.Update(identityInformation);
            return new SuccessResult(Messages.Updated);
        }
    }
}
