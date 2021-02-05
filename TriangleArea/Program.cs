using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, b1, c1, a2, b2, c2;
            double x, y;
            Console.WriteLine("This ");
            Console.Write("Enter coefficient a1: ");
            a1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient b1: ");
            b1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient c1: ");
            c1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient a2: ");
            a2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient b2: ");
            b2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient c2: ");
            c2 = Convert.ToDouble(Console.ReadLine());

            double denominator = a1 * b2 - a2 * b1;
            Console.WriteLine($"denominator is {denominator}");
            if (denominator != 0)
            {
                x = (b1 * c2 - b2 * c1) / denominator;
                y = (a2 * c1 - a1 * c2) / denominator;
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"y = {y}");
                Console.WriteLine($"Lines intercept at ({x},{y})");
            }
        }
    }
}
