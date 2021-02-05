using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double x1, x2;
            Console.Write("Enter coefficient a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient c: ");
            c = Convert.ToDouble(Console.ReadLine());

            double discriminant = b * b - (4 * a * c);
            if (discriminant > 0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"This equation has two solutions:");
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");

            }
            else if (discriminant == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"This equation has 1 solution, x = {x1}");
            }
            else
            {
                Console.WriteLine("This equation has no real solution.");
            }

        }
    }
}
