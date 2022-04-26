using Core.DataAccess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        OperationClaim GetClaim(User user);
        List<User> GetByRoles(string claimName);

    }
}
