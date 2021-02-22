using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 500, ModelYear = "2017", Description = "FORD" },
                new Car { Id = 2, BrandId = 2, ColorId = 2, DailyPrice = 2000, ModelYear = "2019", Description = "BMW" },
                new Car { Id = 3, BrandId = 3, ColorId = 2, DailyPrice = 300, ModelYear = "2010", Description = "TOYOTA" },
                new Car { Id = 4, BrandId = 4, ColorId = 3, DailyPrice = 700, ModelYear = "2017", Description = "AUDİ" },
                new Car { Id = 5, BrandId = 1, ColorId = 4, DailyPrice = 1000, ModelYear = "2020", Description = "FORD" }

            };
        }
            public void Add(Car car)
            {
                _cars.Add(car);
            }

            public void Delete(Car car)
            {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id );
            _cars.Remove(carToDelete);
            }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
            {
                return _cars;
            }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByBrandId(int brandId)
        {
           return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
            {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;

            }
        
    } 
}
