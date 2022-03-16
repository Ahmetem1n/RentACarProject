using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class RentalDetail : IEntity
    {
        public long RentalId { get; set; }
        public long UserId { get; set; }
        public long CarId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int FirstMileage { get; set; }
        public int LastMileage { get; set; }

}
}
