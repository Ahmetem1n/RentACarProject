using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandDal()
        {
            _brands = new List<Brand>
            {
               new Brand{BrandId = 1, BrandName = "Skoda"},
               new Brand{BrandId = 2, BrandName = "Volvo"},
               new Brand{BrandId = 3, BrandName = "Fiat"}
            };
        }
        public Brand GetCarsBrandId(int brandId)
        {
            Brand brand = _brands.SingleOrDefault(b => b.BrandId == brandId);
            return brand;
        }
    }
}
