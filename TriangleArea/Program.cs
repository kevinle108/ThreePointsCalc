using System;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3;
            double area;
            Console.Write("Enter x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter x3: ");
            x3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter y3: ");
            y3 = Convert.ToDouble(Console.ReadLine());

            area = (x1*y2 + x2*y3 + x3*y1 - y1*x2 - y2*x3 - y3*x1) / 2;

            Console.WriteLine($"Area is {area}");
            
        }
    }
}
