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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color {ColorName = "Kahverengi",ColorId= 3 });

            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand {BrandName = "Toyota",BrandId = 2 });


            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car {Id = 8,BrandId = 2,ColorId = 3,DailyPrice = 10000,Description = "Yedinci Model",
                ModelYear = "2009"  });


        
        
        
        
        }

        
    }
}
