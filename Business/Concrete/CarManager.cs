using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

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
            if (car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba veritabanına eklendi");
            }
            else
            {
                Console.WriteLine("Günlük fiyat değeri sıfırdan küçük olamaz");
            }
        }

        public void Delete(Car car)
        {
            Console.WriteLine("Araba veritabanından çıkarıldı");
        }

        public List<Car> GetAll()
        {
            //İş kodları
            return _carDal.GetAll();
            
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice<= max);
        }

        public List<Car> GetByModelYear(string year)
        {
            return _carDal.GetAll(p => p.ModelYear == year);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
            Console.WriteLine("Araba güncellendi");
        }
    }
}
