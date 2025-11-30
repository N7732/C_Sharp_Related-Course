using System;
using name;

namespace name
{

    class Car
    {
        public string Names { get; set; }="";
        public int Year;
        public string Owner{get; set; }="";

        public void Display()
        {
            Console.WriteLine($"Name:{Names}\nYear:{Year}\nOwner:{Owner}\n\nThanks!");
        }
    }

    class Cars
    {
        static void Main()
        {
            Car car = new Car();
            car.Names = "Volvo";
            car.Year = 2019;
            car.Owner = "Olivier";

            car.Display();
        }
    }
}