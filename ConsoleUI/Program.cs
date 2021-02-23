using DataAccess.Concrete.EntityFramework;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //colorManager.Add(new Color { ColorName = "Kahverengi", Id = 3 });



            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName = "Toyota", Id = 2 });

            //CarManager carManager = AddCar();
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.Write("ID : {0}", car.Id + "BrandId: {1}", car.BrandId);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }




        }

        private static CarManager AddCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                Id = 8,
                BrandId = 2,
                ColorId = 3,
                DailyPrice = 10000,
                Description = "Yedinci Model",
                ModelYear = 2009
            });
            return carManager;
        }
    }
}
