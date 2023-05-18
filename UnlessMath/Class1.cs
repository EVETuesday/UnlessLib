using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnlessMath
{
    static public class Algebra
    {
        static public double SumArray(double[] arr)
        {
            if (arr == null || arr.Length==0)
            {
                return 0;
            }
            double res = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                res+= arr[i];
            }
            return res;
        }
        static public double SumArray(string[] arr)
        {
            return 0;
        }

            static public double MaxFromArray(double[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return 0;
            }
            return arr.Max();
        }
        static public double MaxFromArray(string[] arr)
        {
            return 0;
        }
        static public double MinFromArray(double[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return 0;
            }
            return arr.Min();
        }
        static public double MinFromArray(string[] arr)
        {
            return 0;
        }

        static public double AVGArray(double[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return 0;
            }
            return SumArray(arr) / arr.Length;
        }
        static public double AVGArray(string[] arr)
        {
            return 0;
        }
    }

    static public class Geometry
    {
        static public double TrianglAarea(double a, double b)
        {
            if (a<=0 || b<=0)
            {
                return 0;
            }
            return a * b / 2;
        }

        static public double TrianglAarea(string a, string b)
        {
            if (Double.TryParse(a, out double aa) && Double.TryParse(b, out double bb))
            {
                return TrianglAarea(aa,bb);
            }
            else
            {
                return 0;
            }
        }
            static public double TrianglAarea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c<=0)
            {
                return 0;
            }
            double p = a + b+c / 2;
            return Math.Round(Math.Sqrt(p*(p-a)*(p-b)*(p-c)));
        }

        static public double TrianglAarea(string a, string b, string c)
        {
            if (Double.TryParse(a, out double aa) && Double.TryParse(b, out double bb) && Double.TryParse(c, out double cc))
            {
                return TrianglAarea(aa, bb, cc);
            }
            else
            {
                return 0;
            }
        }
        static public double SquareArea(double a)
        {
            if (a <= 0)
            {
                return 0;
            }
            return a * a;
        }
        static public double SquareArea(string a)
        {
            if (Double.TryParse(a, out double aa))
            {
                return SquareArea(aa);
            }
            else
            {
                return 0;
            }
        }

        static public double RectangleArea(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                return 0;
            }
            return a * b;
        }
        static public double RectangleArea(string a, string b)
        {
            if (Double.TryParse(a, out double aa) && Double.TryParse(b, out double bb))
            {
                return RectangleArea(aa, bb);
            }
            else
            {
                return 0;
            }
        }
        static public double RhombusArea(double a, double b)
        {
            if (a <= 0 || b <= 0)
            {
                return 0;
            }
            return a * b / 2 ;
        }

        static public double RhombusArea(string a, string b)
        {
            if (Double.TryParse(a, out double aa) && Double.TryParse(b, out double bb))
            {
                return RhombusArea(aa, bb);
            }
            else
            {
                return 0;
            }
        }
        static public double CircleArea(double r)
        {
            if (r <= 0 )
            {
                return 0;
            }
            return Math.PI * r * r;
        }
        static public double CircleArea(string a)
        {
            if (Double.TryParse(a, out double aa))
            {
                return CircleArea(aa);
            }
            else
            {
                return 0;
            }
        }

    }
    static public class Trigonometry
    {
        static public double Sin(double corner)
        {
            if (corner == 0)
            {
                return 0;
            }
            return Math.Sin(corner);
        }
        static public double Cos(double corner)
        {
            if (corner == 0)
            {
                return 0;
            }
            return Math.Cos(corner);
        }
        static public double Tgn(double corner)
        {
            if (corner == 0)
            {
                return 0;
            }
            return Math.Tan(corner);
        }
        static public double Ctg(double corner)
        {
            if (corner == 0)
            {
                return 0;
            }
            return Math.Tanh(corner);
        }
    }
}
