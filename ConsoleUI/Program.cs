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
            

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 5, ColorId = 2, DailyPrice = 2000, Description = "kiralik", ModelYear = "2009" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
       

        }
    }
}
