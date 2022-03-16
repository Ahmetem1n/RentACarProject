using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public long CustomerId { get; set; }
        public long UserId { get; set; }
        public long IdentityId { get; set; }
        public long DrivingId { get; set; }
        public string Address { get; set; }
}
}
