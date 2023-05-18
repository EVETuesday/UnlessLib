using System;
using UnlessMath;

namespace TestForLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 5;
            int c = 5;
            double[] arr = new double[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine(Algebra.SumArray(arr));
            Console.WriteLine(Algebra.MaxFromArray(arr));
            Console.WriteLine(Algebra.MinFromArray(arr));
            Console.WriteLine(Algebra.AVGArray(arr));

            Console.WriteLine(Geometry.TrianglAarea(a, b));
            Console.WriteLine(Geometry.TrianglAarea(a, b, c));
            Console.WriteLine(Geometry.SquareArea(a));
            Console.WriteLine(Geometry.RectangleArea(a, b));
            Console.WriteLine(Geometry.RhombusArea(a, b));
            Console.WriteLine(Geometry.CircleArea(a));

            Console.WriteLine(Trigonometry.Sin(c));
            Console.WriteLine(Trigonometry.Cos(c));
            Console.WriteLine(Trigonometry.Tgn(c));
            Console.WriteLine(Trigonometry.Ctg(c));

            Console.ReadKey();
        }
    }
}
