using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFCarDal : EFEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = from p in context.Cars
                             join c in context.Colors 
                             on p.ColorId equals c.ColorId
                             join b in context.Brands
                             on p.BrandId equals b.BrandId
                             select new CarDetailDto 
                             { 
                                 CarId = p.CarId,
                                 BrandName = b.BrandName,
                                 ColorName = c.ColorName,
                                 DailyPrice = p.DailyPrice,
                                 Descriptions = p.Descriptions,
                                 ModelYear = p.ModelYear
                             };

                return result.ToList();
            }
        }
    }
}
