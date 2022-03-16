using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public long CarId { get; set; }
        public long BrandId { get; set; }
        public long ColorId { get; set; }
        public long BranchId { get; set; }
        public long GearId { get; set; }
        public long FuelId { get; set; }
        public long ClassId { get; set; }
        public long BodyId { get; set; }
        public long ModelId { get; set; }
        public string CarPlate { get; set; }
        public double CarStar { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
        public Boolean CarUsable { get; set; }
        public string CarLocation { get; set; }
}
}
