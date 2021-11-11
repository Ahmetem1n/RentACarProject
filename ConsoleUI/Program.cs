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
            IBrandService brandService = new BrandManager(new EfBrandDal());
            IColorService colorService = new ColorManager(new EfColorDal());
            ICarService carService = new CarManager(new EfCarDal());

            //CarTest(brandService, colorService, carService);

            //BrandTest(brandService);

            //ColorTest(colorService);
        }

        private static void ColorTest(IColorService colorService)
        {
            foreach( var color in colorService.GetAll().Data){
                Console.WriteLine(color.ColorName);
            }
            //colorService.Add(new Color { ColorName = "Pembe" });
            //colorService.Update(new Color { ColorId = 5, ColorName = "Mor" });
            //colorService.Delete(new Color { ColorId = 5 });
        }

        private static void BrandTest(IBrandService brandService)
        {
            Console.WriteLine(brandService.GetById(1).Data.BrandName);
            //brandService.Add(new Brand { BrandName = "Tofaş" });
            //brandService.Delete(new Brand { BrandId = 5 });
        }

        private static void CarTest(IBrandService brandService, IColorService colorService, ICarService carService)
        {
            carService.Add(new Car { BrandId = 3, ColorId = 1, DailyPrice = 450, ModelYear = 2018, Description = "Otomatik Vites" });
            carService.Delete(new Car { CarId = 3 });
            carService.Update(new Car { CarId = 1, BrandId = 1, ColorId = 2, DailyPrice = 200, ModelYear = 2012, Description = "Otomatik Vites" });

            foreach (var car in carService.GetAll().Data)
            {
                Console.WriteLine(car.CarId + " : " + brandService.GetById(car.BrandId).Data.BrandName + " " + car.Description + " - " + colorService.GetById(car.ColorId).Data.ColorName + " - " + car.DailyPrice);
            }
            Car car1 = carService.GetById(1).Data;
            Console.WriteLine(car1.CarId + " : " + brandService.GetById(car1.BrandId).Data.BrandName + " " + car1.Description + " - " + colorService.GetById(car1.ColorId).Data.ColorName + " - " + car1.DailyPrice);

            foreach (var car in carService.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + " : " + car.ColorName + " " + car.CarDescription + " - " + car.DailyPrice);
            }

        }
    }
}
