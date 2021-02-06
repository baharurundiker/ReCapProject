using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            InMemoryCarDal carDal = new InMemoryCarDal();
            foreach (var car in carDal.GetById(2))
            {
                Console.WriteLine(car.Description);
            }
            foreach (var car in carDal.GetAll())
            {
                Console.WriteLine(car.ModelYear);
            }
        }
    }
}
