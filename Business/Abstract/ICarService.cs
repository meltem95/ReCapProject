using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarByBrandId(int id);
        IDataResult<List<Car>> GetCarByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetById(int carId);


    }
}
