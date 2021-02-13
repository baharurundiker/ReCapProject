using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car{Id = 1,BrandId = 6 ,ColorId = 5,ModelYear ="2001",DailyPrice = 60000,Description = "Birinci Model"},
                new Car{Id = 2,BrandId = 1 ,ColorId = 5,ModelYear ="2005",DailyPrice = 50000,Description = "İkinci Model"},
                new Car{Id = 3,BrandId = 7 ,ColorId = 1,ModelYear ="2010",DailyPrice = 70000,Description = "Üçüncü Model"},
                new Car{Id = 4,BrandId = 3 ,ColorId = 2,ModelYear ="1995",DailyPrice = 65000,Description = "Dördüncü Model"},
                new Car{Id = 5,BrandId = 9 ,ColorId = 2,ModelYear ="2017",DailyPrice = 80000,Description = "Beşinci Model"},
                new Car{Id = 6,BrandId = 7 ,ColorId = 3,ModelYear ="2012",DailyPrice = 64000,Description = "Altıncı Model"}

            };
        }
       
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
