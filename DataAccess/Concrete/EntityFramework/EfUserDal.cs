using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentACarProjectContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new RentACarProjectContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.ClaimId equals userOperationClaim.DetailId
                             where userOperationClaim.UserId == user.UserId
                             select new OperationClaim { ClaimId = operationClaim.ClaimId, ClaimName = operationClaim.ClaimName };
                return result.ToList();

            }
        }
    }
}
