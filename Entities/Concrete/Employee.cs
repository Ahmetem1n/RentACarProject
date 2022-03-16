using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public long EmployeeId { get; set; }
        public long UserId  { get; set; }
}
}
