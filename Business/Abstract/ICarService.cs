using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        void Insert(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAllByColorId(int id);
        List<Car> GetAllById(int id);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        List<Car> GetByModelYear(string year);
        List<CarDetailDto> GetCarDetails();
    }
}
