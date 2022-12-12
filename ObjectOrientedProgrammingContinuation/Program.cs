using System;

namespace ObjectOrientedProgrammingContinuation
{
    public class Student
    {
        private string LastName { get; }
        private int Age { get; }

        public string Name { get; }
    }

    public class Car
    {
        private readonly string _brand;

        public static int NumberOfCars { get; set; }

        public Car(string brand)
        {
            NumberOfCars++;
            _brand = brand;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Car("Ford mondeo");
            var c2 = new Car("Tesla");
            var c3 = new Car("Mercedes E200");
            var c4 = new Car("Volvo X90");

            //Car.NumberOfCars = 100;
            Console.WriteLine(Car.NumberOfCars);

            
        }

        private static void InterfacePracticalDemo()
        {
            var p = new InvoiceProcessor(new DummyLinesProvider());
            var result = p.GroupByCategory();

            //var p = new InvoiceProcessor(new FileLinesProvider());
            //p.GroupByCategory();
        }

        private static void InterfaceDemo()
        {
            var tesla = new ElectricalCar();
            tesla.Drive();
            Console.WriteLine(tesla.IsCharged());
        }

        public static void Display(Shape shape) => 
            Console.WriteLine($"The area is {shape.Area()} and the perimeter is {shape.Perimeter()}");

        private static void InheritanceDemo()
        {
            var s = new Square(5);
            var r = new Rectangle(3, 4);
            var c = new Circle(6);
            var t = new Triangle();

            Console.WriteLine($"The area is {s.Area()} and the perimeter is {s.Perimeter()}");
            Console.WriteLine($"The area is {r.Area()} and the perimeter is {r.Perimeter()}");
            Console.WriteLine($"The area is {c.Area()} and the perimeter is {c.Perimeter()}");
            Console.WriteLine($"The area is {t.Area()} and the perimeter is {t.Perimeter()}");

            Display(s);
            Display(r);
            Display(c);
            Display(t);

            //no longer possible because we marked Shape as abstract
            //Shape x = new Shape();
            //Display(x);
        }

        private static void TechnicalAspectsReview()
        {
            var a = new A();
            a.MyMethod();

            var b = new B();
            b.MyMethod();
        }
    }
}
