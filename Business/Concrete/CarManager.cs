using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {

            using (SampleDatabaseContext context = new SampleDatabaseContext())
            {
                if (car.DailyPrice > 0 && context.Brands.SingleOrDefault(b => b.BrandId == car.BrandId).BrandName.Length > 2)
                {
                    _carDal.Add(car);
                }
                else
                {
                    Console.WriteLine("Ekleme işleminiz yapılamamıştır.");
                }

            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId==id);
        }

        public List<Car> GetCarByColorId(int id)
        {
            return _carDal.GetAll(c=>c.ColorId==id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }



   
}
