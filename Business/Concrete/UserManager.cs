using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    //[SecuredOperation("Yönetici,Çalışan")]
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        IUserOperationClaimService _userOperationClaimService;

        public UserManager(IUserDal userDal, IUserOperationClaimService userOperationClaimService)
        {
            _userDal = userDal;
            _userOperationClaimService = userOperationClaimService;
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(User user)
        {
            var userOperationClaim = _userOperationClaimService.GetByUserId(user.UserId).Data;
            if (userOperationClaim != null)
            {
                _userOperationClaimService.Delete(userOperationClaim);
            }
            _userDal.Delete(user);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<User>> GetByRoles(string claimName)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetByRoles(claimName), Messages.Listed);
        }

        public IDataResult<User> GetById(long userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == userId), Messages.Get);
        }

        public IDataResult<User> GetByMail(string email)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Email == email));
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccessResult(Messages.Updated);
        }

        public IDataResult<List<UserDetailDto>> GetUserDetails()
        {
            var users = _userDal.GetAll();
            List<UserDetailDto> userDetailDto = new List<UserDetailDto>();

            foreach (var user in users)
            {
                userDetailDto.Add(new UserDetailDto
                {
                    UserId = user.UserId,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    NationalityId = user.NationalityId,
                    BirthYear = user.BirthYear,
                    Photo = user.Photo,
                    Status = user.Status,
                    PasswordHash = user.PasswordHash,
                    PasswordSalt = user.PasswordSalt,
                    ClaimName = GetByUserClaim(user).ClaimName,
                    ClaimId = GetByUserClaim(user).ClaimId
                });
            }

            return new SuccessDataResult<List<UserDetailDto>>(userDetailDto, Messages.Listed);
        }

        public OperationClaim GetByUserClaim(User user)
        {
            var result = _userDal.GetByUserClaim(user);
            return result != null ? result : new OperationClaim { ClaimId = 0, ClaimName = "Yetki Yok" };
        }

        public IDataResult<List<UserDetailDto>> GetByCustomers()
        {
            return new SuccessDataResult<List<UserDetailDto>>(_userDal.GetByCustomers());
        }

        public IDataResult<UserDetailDto> GetByUserId(long userId)
        {
            return new SuccessDataResult<UserDetailDto>(GetUserDetails().Data.Find(u => u.UserId == userId));
        }
    }
}
