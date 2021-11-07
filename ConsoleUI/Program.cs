using System;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService carService = new CarManager(new EfCarDal());
            IBrandService brandService = new BrandManager(new EfBrandDal());
            IColorService colorService = new ColorManager(new EfColorDal());

            carService.Add(new Car { CarId = 4, BrandId = 3, ColorId = 1, DailyPrice = 450, ModelYear = 2018, Description = "Otomatik Vites" });
            carService.Delete(new Car{CarId = 3});
            carService.Update(new Car { CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 200, ModelYear = 2012, Description = "Otomatik Vites" });
            carService.getCarsByColorId(1);
            foreach (var car in carService.GetCarsByBrandId(1))
            {
                Console.WriteLine("FİLTRELER ÇALIŞMIYOR");
                Console.WriteLine(car.CarId + " : " +brandService.GetById(car.BrandId).BrandName+" " + car.Description + " - " + colorService.GetById(car.ColorId).ColorName + " - " + car.DailyPrice);
            }
            Car car1 = carService.GetById(1);
            Console.WriteLine(car1.CarId + " : " + brandService.GetById(car1.BrandId).BrandName + " " + car1.Description + " - " + colorService.GetById(car1.ColorId).ColorName + " - " + car1.DailyPrice);

        }
    }
}
