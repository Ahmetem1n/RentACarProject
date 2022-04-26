using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class BloodGroup:IEntity
    {
        public long BloodGroupId { get; set; }
        public string BloodGroupName { get; set; }
    }
}
