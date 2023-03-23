using System;
using System.Collections.Generic;

namespace Лаба10
{
    class Program
    {
        static void Main(string[] args)
        {

            Garage garage = new Garage(new Car("Toyota"), new Car("Tesla"));
            Washer washer = new Washer();

            CarWasher carWasher = washer.Wash;

            foreach (Car car in garage.cars)
            {
                carWasher(car);
            }
        }

      
}
    }
delegate void CarWasher(Car car);
    
    class Car
    {
        public string Name { get; set; }

        public Car(string name)
        {
            Name = name;
        }
    }

    class Garage
    {
        public List<Car> cars = new List<Car>();

        public Garage(params Car[] autos)
        {
            foreach (Car car in autos)
            {
                cars.Add(car);
            }
        }
    }

    class Washer
    {
        public void Wash(Car car)
        {
            Console.WriteLine($"Автомобиль {car.Name} помыт.");
        }
    }


