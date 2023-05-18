using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unless50Tests
{
    [TestClass]
    public class UnitTest1
    {
        //--------------------------------------------------------------------------------Algebra
        [TestMethod]
        public void TestMethod1()
        {
            double[] arr = new double[] { 1, 2, 3, 4, 5 };
            double res = UnlessMath.Algebra.SumArray(arr);
            Assert.AreEqual(15, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double[] arr = new double[] { -1, 2, 3, 0, 5 };
            double res = UnlessMath.Algebra.SumArray(arr);
            Assert.AreEqual(9, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double[] arr = new double[] { };
            double res = UnlessMath.Algebra.SumArray(arr);
            Assert.AreEqual(0, res);
        }

        //----------------------------------------------------

        [TestMethod]
        public void TestMethod4()
        {
            double[] arr = new double[] { 1, 2, 3, 4, 5 };
            double res = UnlessMath.Algebra.MaxFromArray(arr);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestMethod5()
        {
            double[] arr = new double[] { -1, 2, 3, 0, 5 };
            double res = UnlessMath.Algebra.MaxFromArray(arr);
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void TestMethod6()
        {
            double[] arr = new double[] { };
            double res = UnlessMath.Algebra.MaxFromArray(arr);
            Assert.AreEqual(0, res);
        }

        //----------------------------------------------------

        [TestMethod]
        public void TestMethod7()
        {
            double[] arr = new double[] { 1, 2, 3, 4, 5 };
            double res = UnlessMath.Algebra.MinFromArray(arr);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestMethod8()
        {
            double[] arr = new double[] { -1, 2, 3, 0, 5 };
            double res = UnlessMath.Algebra.MinFromArray(arr);
            Assert.AreEqual(-1, res);
        }
        [TestMethod]
        public void TestMethod9()
        {
            double[] arr = new double[] { };
            double res = UnlessMath.Algebra.MinFromArray(arr);
            Assert.AreEqual(0, res);            
        }

        //----------------------------------------------------

        [TestMethod]
        public void TestMethod10()
        {
            double[] arr = new double[] {1, 1, 1, 1, 1};
            double res = UnlessMath.Algebra.AVGArray(arr);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestMethod11()
        {
            double[] arr = new double[] { -1, 1, 1, 1, 3 };
            double res = UnlessMath.Algebra.AVGArray(arr);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void TestMethod12()
        {
            double[] arr = new double[] { };
            double res = UnlessMath.Algebra.AVGArray(arr);
            Assert.AreEqual(0, res);
        }
        //--------------------------------------------------------------------------------Geometry
        [TestMethod]
        public void TestMethod13()
        {
            double a = 4;
            double b = 5;
            double res = UnlessMath.Geometry.TrianglAarea(a,b);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestMethod14()
        {
            double a = -4;
            double b = 5;
            double res = UnlessMath.Geometry.TrianglAarea(a, b);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMethod15()
        {
            double a = 0;
            double b = 5;
            double res = UnlessMath.Geometry.TrianglAarea(a, b);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMethod16()
        {
            double a = 4;
            double b = 5;
            double c = 3;
            double res = UnlessMath.Geometry.TrianglAarea(a, b, c);
            Assert.AreEqual(53, res);
        }
        [TestMethod]
        public void TestMethod41()
        {
            string a = "4";
            string b = "5";
            double res = UnlessMath.Geometry.TrianglAarea(a, b);
            Assert.AreEqual(10, res);
        }
        [TestMethod]
        public void TestMethod42()
        {
            string a = "A";
            string b = "Hello";
            double res = UnlessMath.Geometry.TrianglAarea(a, b);
            Assert.AreEqual(0, res);
        }

        //----------------------------------------------------
        [TestMethod]
        public void TestMethod17()
        {
            double a = 4;
            double res = UnlessMath.Geometry.SquareArea(a);
            Assert.AreEqual(16, res);
        }

        [TestMethod]
        public void TestMethod18()
        {
            double a = -4;
            double res = UnlessMath.Geometry.SquareArea(a);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMethod19()
        {
            double a = 0;
            double res = UnlessMath.Geometry.SquareArea(a);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMethod43()
        {
            string a = "4";
            double res = UnlessMath.Geometry.SquareArea(a);
            Assert.AreEqual(16, res);
        }
        [TestMethod]
        public void TestMethod44()
        {
            string a = "Hello";
            double res = UnlessMath.Geometry.SquareArea(a);
            Assert.AreEqual(0, res);
        }


        //----------------------------------------------------
        [TestMethod]
        public void TestMethod20()
        {
            double a = 4;
            double b = 5;
            double res = UnlessMath.Geometry.RectangleArea(a,b);
            Assert.AreEqual(20, res);
        }

        [TestMethod]
        public void TestMethod21()
        {
            double a = -4;
            double b = 5;
            double res = UnlessMath.Geometry.RectangleArea(a, b);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMethod22()
        {
            double a = 0;
            double b = 5;
            double res = UnlessMath.Geometry.RectangleArea(a, b);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMethod45()
        {
            string a = "4";
            string b = "5";
            double res = UnlessMath.Geometry.RectangleArea(a, b);
            Assert.AreEqual(20, res);
        }
        [TestMethod]
        public void TestMethod46()
        {
            string a = "A";
            string b = "Hello";
            double res = UnlessMath.Geometry.RectangleArea(a, b);
            Assert.AreEqual(0, res);
        }
        //----------------------------------------------------
        [TestMethod]
        public void TestMethod23()
        {
            double a = 4;
            double b = 5;
            double res = UnlessMath.Geometry.RhombusArea(a, b);
            Assert.AreEqual(10, res);
        }

        [TestMethod]
        public void TestMethod24()
        {
            double a = -4;
            double b = 5;
            double res = UnlessMath.Geometry.RhombusArea(a, b);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMethod25()
        {
            double a = 0;
            double b = 5;
            double res = UnlessMath.Geometry.RhombusArea(a, b);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMethod47()
        {
            string a = "4";
            string b = "5";
            double res = UnlessMath.Geometry.RhombusArea(a, b);
            Assert.AreEqual(10, res);
        }
        [TestMethod]
        public void TestMethod48()
        {
            string a = "A";
            string b = "Hello";
            double res = UnlessMath.Geometry.RhombusArea(a, b);
            Assert.AreEqual(0, res);
        }
        //----------------------------------------------------
        [TestMethod]
        public void TestMethod26()
        {
            double a = 4;
            double res = UnlessMath.Geometry.CircleArea(a);
            Assert.AreEqual(Math.PI*16, res);
        }

        [TestMethod]
        public void TestMethod27()
        {
            double a = -4;
            double res = UnlessMath.Geometry.CircleArea(a);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMethod28()
        {
            double a = 0;
            double res = UnlessMath.Geometry.CircleArea(a);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestMethod49()
        {
            string a = "4";
            double res = UnlessMath.Geometry.CircleArea(a);
            Assert.AreEqual(Math.PI * 16, res);
        }
        [TestMethod]
        public void TestMethod50()
        {
            string a = "Hello";
            double res = UnlessMath.Geometry.CircleArea(a);
            Assert.AreEqual(0, res);
        }
        //--------------------------------------------------------------------------------Trigonometry
        [TestMethod]
        public void TestMethod29()
        {
            double a = 5;
            double res = UnlessMath.Trigonometry.Sin(a);
            Assert.AreEqual(Math.Sin(a), res);
        }

        [TestMethod]
        public void TestMethod30()
        {
            double a = -5;
            double res = UnlessMath.Trigonometry.Sin(a);
            Assert.AreEqual(Math.Sin(a), res);
        }
        [TestMethod]
        public void TestMethod31()
        {
            double a = 0;
            double res = UnlessMath.Trigonometry.Sin(a);
            Assert.AreEqual(0, res);
        }
        //----------------------------------------------------
        [TestMethod]
        public void TestMethod32()
        {
            double a = 5;
            double res = UnlessMath.Trigonometry.Cos(a);
            Assert.AreEqual(Math.Cos(a), res);
        }

        [TestMethod]
        public void TestMethod33()
        {
            double a = -5;
            double res = UnlessMath.Trigonometry.Cos(a);
            Assert.AreEqual(Math.Cos(a), res);
        }
        [TestMethod]
        public void TestMethod34()
        {
            double a = 0;
            double res = UnlessMath.Trigonometry.Cos(a);
            Assert.AreEqual(0, res);
        }
        //----------------------------------------------------
        [TestMethod]
        public void TestMethod35()
        {
            double a = 5;
            double res = UnlessMath.Trigonometry.Tgn(a);
            Assert.AreEqual(Math.Tan(a), res);
        }

        [TestMethod]
        public void TestMethod36()
        {
            double a = -5;
            double res = UnlessMath.Trigonometry.Tgn(a);
            Assert.AreEqual(Math.Tan(a), res);
        }
        [TestMethod]
        public void TestMethod37()
        {
            double a = 0;
            double res = UnlessMath.Trigonometry.Tgn(a);
            Assert.AreEqual(0, res);
        }
        //----------------------------------------------------
        [TestMethod]
        public void TestMethod38()
        {
            double a = 5;
            double res = UnlessMath.Trigonometry.Ctg(a);
            Assert.AreEqual(Math.Tanh(a), res);
        }

        [TestMethod]
        public void TestMethod39()
        {
            double a = -5;
            double res = UnlessMath.Trigonometry.Ctg(a);
            Assert.AreEqual(Math.Tanh(a), res);
        }
        [TestMethod]
        public void TestMethod40()
        {
            double a = 0;
            double res = UnlessMath.Trigonometry.Ctg(a);
            Assert.AreEqual(0, res);
        }
        //--------------------------------------------------------------------------------
    }
}
