﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory ford_car = FordFactory.MyFordFactory;
           // CarFactory ford_car = new FordFactory();
            Client c1 = new Client(ford_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, кузов: {2}",
            c1.ToString(), c1.RunMaxSpeed(), c1.BodyType());

            CarFactory audi_car = AudiFactory.MyAudiFactory;
            Client c2 = new Client(audi_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, кузов: {2}",
            c2.ToString(), c2.RunMaxSpeed(), c2.BodyType());

            Console.Read();
        }
    }
}
