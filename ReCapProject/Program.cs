﻿using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager car = new CarManager(new InMemoryCarDal());
            foreach (var item in car.GetAll())
            {
                Console.WriteLine(item.Description);
            }
            Console.Read();
        }
    }
}
