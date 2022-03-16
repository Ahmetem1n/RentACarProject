using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Model : IEntity
    {
        public long ModelId { get; set; }
        public string ModelName { get; set; }
    }
}
