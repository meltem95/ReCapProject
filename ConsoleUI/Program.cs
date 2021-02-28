using System;
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
            //CarTest();
            // BrandTest();
            // ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine(colorManager.GetById(3).Data.ColorName);
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success==true)
            {
                   foreach (var car in result.Data)
                   {
                     Console.WriteLine(car.BrandName + '/' + car.ColorName  + '/' + car.ModelYear + '/' + car.DailyPrice );
                   }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }
    }
}
