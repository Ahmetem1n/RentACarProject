using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            
            _cars = new List<Car>
            {
                new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 250, ModelYear = 2015, Description = "Otomatik Vites" },
                new Car { CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 150, ModelYear = 2012, Description = "Otomatik Vites" },
                new Car { CarId = 3, BrandId = 3, ColorId = 3, DailyPrice = 190, ModelYear = 2014, Description = "Manuel Vites"}
            };
        }
        public Car GetById(int carId)
        {
            Car car = _cars.SingleOrDefault(c => c.CarId == carId);
            return car;
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }
    }
}
