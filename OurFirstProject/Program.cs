using System;
using System.Collections.Generic;

namespace OurFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            for (var i = 0; i < 4; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            var sum = 0;
            for (var i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            var average = 1.0 * sum / list.Count;
            Console.WriteLine($"Sum is {sum} and average is {average}");
        }

        private static void Task10b()
        {
            var numbers = new int[4];

            for (var i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var sum = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            var average = 1.0 * sum / numbers.Length;
            Console.WriteLine($"Sum is {sum} and average is {average}");
        }

        private static void Task10()
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());

            int sum = number1 + number2 + number3 + number4;
            double average = 1.0 * sum / 4;

            Console.WriteLine($"Sum is {sum} and average is {average}");
        }

        private static void Task3()
        {
            double radius = Convert.ToDouble(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area is {area}");
        }

        private static void Task2()
        {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
        }

        private static void Task1()
        {
            string name = "Marcin";
            Console.Write("Hello ");
            Console.WriteLine(name);

            Console.WriteLine("Hello " + name);

            Console.WriteLine(string.Format("Hello {0}", name));

            Console.WriteLine($"Hello {name}");  //USE THIS !
        }
    }
}