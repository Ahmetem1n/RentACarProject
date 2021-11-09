using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandCar : IBrandDal
    {
        List<Brand> _brands;
        public InMemoryBrandCar()
        {
            _brands = new List<Brand>
            {
               new Brand{BrandId = 1, BrandName = "Skoda"},
               new Brand{BrandId = 2, BrandName = "Volvo"},
               new Brand{BrandId = 3, BrandName = "Fiat"}
            };
        }

        public void Add(Brand entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Brand GetCarsBrandId(int brandId)
        {
            Brand brand = _brands.SingleOrDefault(b => b.BrandId == brandId);
            return brand;
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
