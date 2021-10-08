using System;

namespace Class.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();

            newCar.Make = "Audi";
            newCar.Model = "A4";
            newCar.Year = 2020;

            Console.WriteLine($"Make: {newCar.Make}");
            Console.WriteLine($"Model: {newCar.Model}");
            Console.WriteLine($"Year: {newCar.Year}");
        }
    }
}
