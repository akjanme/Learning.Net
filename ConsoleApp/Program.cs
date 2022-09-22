using System;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.CarDetails();






            //Car car = new Car
            //{
            //    Color = "Red",
            //    Model = 2021,
            //    IsElectric = false,
            //    Speed = "100"
            //}; //object creation
            //Console.WriteLine("Car Model is {0}, color is {1}, speed is {2} and is electric {3}", car.Model, car.Color, car.Speed, car.IsElectric);

            //Car car1 = new Car
            //{
            //    Color = "White",
            //    Model = 2020,
            //    IsElectric = false,
            //    Speed = "140"
            //}; //object creation
            //Console.WriteLine("Car Model is {0}, color is {1}, speed is {2} and is electric {3}", car1.Model, car1.Color, car1.Speed, car1.IsElectric);
            //Console.WriteLine("Car Model is {0}, color is {1}, speed is {2} and is electric {3}", car.Model, car.Color, car.Speed, car.IsElectric);
            Console.ReadKey();
        }
    }
    class Fruit
    {

    }
    public class Car
    {
        private int Model;
        private string Color;
        private string Speed;
        private bool IsElectric;

        public void CarDetails()
        {
            Car car = new Car
            {
                Color = "Red",
                Model = 2021,
                IsElectric = false,
                Speed = "100"
            };
            Console.WriteLine("Car Model is {0}, color is {1}, speed is {2} and is electric {3}", car.Model, car.Color, car.Speed, car.IsElectric);
        }
    }
    public class Calculation
    {
        public int Num1;
        public int Num2;
        public int Total;
    }
}
