using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //Car car1 = new Car() { BrandId = 1, ColorId = 3, ModelYear = 2020, Description = "Yeni Araba", DailyPrice = 1500 };
            //Brand brand1 = new Brand() { Name = "Yeni Marka" };
            //Color color1 = new Color() { Name = "Yeni Renk" };

            //carManager.Add(car1);
            //brandManager.Add(brand1);
            //colorManager.Add(color1);

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Id : " + car.Id);
                Console.WriteLine("Modeli : " + car.CarName);
                Console.WriteLine("Markası : " + car.BrandName);
                Console.WriteLine("Rengi : " + car.ColorName);
                Console.WriteLine("Günlük fiyatı : " + car.DailyPrice);
                Console.WriteLine("--------------------------------");
            }

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Description);
            //}
            //Console.WriteLine("--------------------------");
            //foreach (var car in brandManager.GetAll())
            //{
            //    Console.WriteLine(car.Name);
            //}
            //Console.WriteLine("--------------------------");
            //foreach (var car in colorManager.GetAll())
            //{
            //    Console.WriteLine(car.Name);
            //}

            //Console.WriteLine(carManager.GetById(1).Description);
            //Console.WriteLine(brandManager.GetById(1).Name);
            //Console.WriteLine(colorManager.GetById(1).Name);
        }
    }
}
