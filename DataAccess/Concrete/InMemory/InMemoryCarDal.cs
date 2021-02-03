using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { BrandId = 1, ColorId = 2, DailyPrice = 5000000, Description = "CRV", Id = 4, ModelYear = 2012 },
                new Car { BrandId = 2, ColorId = 2, DailyPrice = 5000000, Description = "Fiat", Id = 1, ModelYear = 2010 },
                new Car { BrandId = 3, ColorId = 2, DailyPrice = 5000000, Description = "CRV", Id = 3, ModelYear = 2012 }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }

        List<Car> ICarDal.GetAllByBrand(int BrandId)
        {
            return _cars.Where(p => p.BrandId == BrandId).ToList();
        }
    }
}
