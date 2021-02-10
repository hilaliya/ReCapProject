using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = IdTest();
            //ColorTest(carManager);
            //DailyPriceTest(carManager);

        }

        private static void DailyPriceTest(CarManager carManager)
        {
            Console.WriteLine("\n\nGünlük fiyat aralığı 100 ile 180 olan arabalar: ");
            foreach (var car in carManager.GetByDailyPrice(100, 180))
            {
                Console.WriteLine(car.Descriptions);
            }
            Console.WriteLine("\n");
        }

        private static void ColorTest(CarManager carManager)
        {
            Console.WriteLine("\n\nColor Id'si 2 olan arabalar: ");
            foreach (var car in carManager.GetAllByColorId(2))
            {
                Console.WriteLine(car.Descriptions);
            }
        }

        private static CarManager IdTest()
        {
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("Arabalar: ");
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.Descriptions + " / " + car.ColorName + " / " + car.BrandName + " / " + car.DailyPrice);
            }

            return carManager;
        }
    }
}
