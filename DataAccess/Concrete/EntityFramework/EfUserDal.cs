using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentACarProjectContext>, IUserDal
    {
        public List<User> GetByRoles(string claimName)
        {
            using (var context = new RentACarProjectContext())
            {
                var result = from user in context.Users
                             join userOperationClaim in context.UserOperationClaims
                                 on user.UserId equals userOperationClaim.UserId
                             join operationClaim in context.OperationClaims
                                on userOperationClaim.ClaimId equals operationClaim.ClaimId
                             where operationClaim.ClaimName == claimName
                             select new User { UserId = user.UserId, FirstName = user.FirstName, LastName = user.LastName, NationalityId = user.NationalityId, Email = user.Email, Photo = user.Photo, PasswordSalt = user.PasswordSalt, PasswordHash = user.PasswordHash, Status = user.Status, BirthYear = user.BirthYear };
                return result.ToList();
            }
        }

        public OperationClaim GetClaim(User user)
        {
            using (var context = new RentACarProjectContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.ClaimId equals userOperationClaim.DetailId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { ClaimId = operationClaim.ClaimId, ClaimName = operationClaim.ClaimName };
                return result.FirstOrDefault();

            }
        }

        public List<UserDetailDto> GetUserDetails()
        {
            using (RentACarProjectContext context = new RentACarProjectContext())
            {
                var result = from u in context.Users
                             join us in context.UserOperationClaims
                             on u.UserId equals us.UserId
                             join o in context.OperationClaims
                             on us.ClaimId equals o.ClaimId
                             select new UserDetailDto { UserId = u.UserId, BirthYear = u.BirthYear, Email = u.Email, FirstName = u.FirstName, LastName = u.LastName, NationalityId = u.NationalityId, Photo = u.Photo, Status = u.Status, ClaimName = o.ClaimName };
                return result.ToList();
            }
        }
    }
}
