using System;
using BusinessLogic;

namespace ObjectOrientedProgrammingBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new Car("Opel", "Insignia", 60, 6);
            c.AddFuel(10);
            c.AddFuel(100);
            Console.WriteLine(c.FuelLevel);
            Console.WriteLine(c.Odometer);
            c.Drive(500);
            Console.WriteLine(c.FuelLevel);
            Console.WriteLine(c.Odometer);
            c.Drive(1000);
            Console.WriteLine(c.FuelLevel);
            Console.WriteLine(c.Odometer);
            Console.WriteLine(c.DailyOdometer);

            //var s = new Student("James Bond", new DateTime(1950,11,14));
            //Console.WriteLine($"{s.Name} is {s.Age}");
            //s.Name = "Janine Bond";
            //Console.WriteLine($"{s.Name} is {s.Age}");
            //Console.WriteLine(s.IsBrithDayToday);
            //Console.ReadKey();
        }
    }
}
