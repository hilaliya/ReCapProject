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
            CarManager carManager = new CarManager(new EFCarDal());
            Console.WriteLine("Brand Id'si 1 olan arabalar: ");
            foreach (var car in carManager.GetAllByBrandId(1))
            {
                Console.WriteLine(car.Descriptions);
            }

            Console.WriteLine("\n\nColor Id'si 2 olan arabalar: ");
            foreach (var car in carManager.GetAllByColorId(2))
            {
                Console.WriteLine(car.Descriptions);
            }


            Console.WriteLine("\n\nGünlük fiyat aralığı 100 ile 180 olan arabalar: ");
            foreach (var car in carManager.GetByDailyPrice(100, 180))
            {
                Console.WriteLine(car.Descriptions);
            }
                Console.WriteLine("\n");


        }
    }
}
