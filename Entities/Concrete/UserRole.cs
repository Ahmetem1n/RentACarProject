using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class UserRole : IEntity
    {
        public long RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
