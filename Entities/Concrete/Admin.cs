using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Admin : IEntity
    {
        public long AdminId { get; set; }
        public long UserId { get; set; }
    }

}
