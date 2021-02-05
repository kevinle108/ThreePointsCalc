using System;
using System.Collections.Generic;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double a1, b1, c1, a2, b2, c2, a3, b3, c3;
            //double x1, x2, x3, y1, y2, y3;
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

            Console.Write("Enter coefficient a3: ");
            a3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient b3: ");
            b3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient c3: ");
            c3 = Convert.ToDouble(Console.ReadLine());

            // first point 1|2
            List<double> firstPoint = InterceptLines(a1, b1, c1, a2, b2, c2);

            // second point 2|3
            List<double> secondPoint = InterceptLines(a2, b2, c2, a3, b3, c3);

            // third point 1|3
            List<double> thirdPoint = InterceptLines(a1, b1, c1, a3, b3, c3);

            if (firstPoint.Count == 0 || secondPoint.Count == 0 || thirdPoint.Count == 0)
            {
                Console.WriteLine($"One of the lines don't intercept!");
                return;
            }
            else
            {
                double area = TriangleArea(firstPoint[0], secondPoint[0], thirdPoint[0], firstPoint[1], secondPoint[1], thirdPoint[1]);
                Console.WriteLine($"area = {area}");

            }
            // FUNCTIONS //

            // first value in array is x, second value is y. If empty array, then no solution
            List<double> InterceptLines(double a1, double b1, double c1, double a2, double b2, double c2)
            {
                List<double> result = new List<double>();
                double denominator = a1 * b2 - a2 * b1;
                double x, y;
                if (denominator != 0)
                {
                    x = (b1 * c2 - b2 * c1) / denominator;
                    y = (a2 * c1 - a1 * c2) / denominator;
                    result.Add(x);
                    result.Add(y);
                }
                return result;
            }

            double TriangleArea(double x1, double x2, double x3, double y1, double y2, double y3) { 
                return (x1 * y2 + x2 * y3 + x3 * y1 - y1 * x2 - y2 * x3 - y3 * x1) / 2;
            }
            
        }
    }
}
