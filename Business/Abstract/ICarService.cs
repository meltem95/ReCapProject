using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);

        List<Car> GetAll();
        List<Car> GetCarByBrandId(int id);
        List<Car> GetCarByColorId(int id);
        List<CarDetailDto> GetCarDetails();


    }
}
