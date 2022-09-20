using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(); //object creation
            car.Color = "Red";
            car.Model = 2021;
            car.IsElectric = false;
            car.Speed = "100";
            Console.WriteLine("Car Model is {0}, color is {1}, speed is {2} and is electric {3}", car.Model, car.Color, car.Speed, car.IsElectric);

            Car car1 = new Car(); //object creation
            car1.Color = "White";
            car1.Model = 2020;
            car1.IsElectric = false;
            car1.Speed = "140";
            Console.WriteLine("Car Model is {0}, color is {1}, speed is {2} and is electric {3}", car1.Model, car1.Color, car1.Speed, car1.IsElectric);

            Console.WriteLine("Car Model is {0}, color is {1}, speed is {2} and is electric {3}", car.Model, car.Color, car.Speed, car.IsElectric);

            Console.ReadKey();
        }
    } 
    class Car
    {
        public int Model;
        public string Color;
        public string Speed;
        public bool IsElectric;
    }
}
