using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TasksEpam.Project1
{
    [TestFixture]
    class TestHW1
    {
        //TestClass_TestMethod_ConditionAndExpectedResult 
        //TestMethod_Condition_ExpectedResult
        [TestFixture]
        class TestTask1
        {
            [TestCase]
            public void Task1_TestPerimetr_InputIs0_Expect0()
            {
                Rectangle rectangle = new Rectangle(new Point(), new Point());
                Assert.AreEqual(0, rectangle.Perimetr());
            }
            [TestCase]
            public void Task1_TestPerimetr_ValidParams_ExpectEqual()
            {
                Rectangle rectangle = new Rectangle(new Point(0, 4), new Point(5, 1));
                Assert.AreEqual(16, rectangle.Perimetr());
            }
            [TestCase]
            public void Task1_TestSquare_InputIs0_Expect0()
            {
                Rectangle rectangle = new Rectangle(new Point(), new Point());
                Assert.AreEqual(0, rectangle.Square());
            }
            [TestCase]
            public void Task1_TestProperties_ValidParams_ExpectEqual()
            {
                Rectangle rectangle = new Rectangle(new Point(-2, 3), new Point(7, 0));
                Assert.AreEqual(-2, rectangle.LT.X);
                Assert.AreEqual(3, rectangle.LT.Y);
                Assert.AreEqual(7, rectangle.RB.X);
                Assert.AreEqual(0, rectangle.RB.Y);
                rectangle.LT.X = 5;
                Assert.AreEqual(5, rectangle.LT.X);
            }
            [TestCase]
            public void Task1_TestConstructor_NotValidParams_EqualException()
            {
                Assert.Throws<Exception>(() => new Rectangle(new Point(6, 4), new Point(5, 1)));
            }
        }

        [TestFixture]
        class TestTask2
        {
            [TestCase]
            public void Task2_TestPerimetr_InputIs0_Expect0()
            {
                RectangleProperties rectangle = new RectangleProperties(new Point(), new Point());
                Assert.AreEqual(0, rectangle.Perimetr);
            }
            [TestCase]
            public void Task2_TestPerimetr_ValidParams_Expect18()
            {
                RectangleProperties rectangle = new RectangleProperties(new Point(-2, 2), new Point(5, 0));
                Assert.AreEqual(18, rectangle.Perimetr);
            }
            [TestCase]
            public void Task2_TestSquare_InputIs0_Expect0()
            {
                RectangleProperties rectangle = new RectangleProperties(new Point(), new Point());
                Assert.AreEqual(0, rectangle.Square);
            }
            public void Task2_TestSquare_ValidParams_ExpectEqual()
            {
                RectangleProperties rectangle = new RectangleProperties(new Point(0,4), new Point(4,0));
                Assert.AreEqual(16, rectangle.Square);
            }
            [TestCase]
            public void Task2_TestConstructor_NotValidParams_ExpectException()
            {
                Assert.Throws<Exception>(() => new RectangleProperties(new Point(-2, 10), new Point(-10, 1)));
            }
        }

        [TestFixture]
        class TestTask3
        {
            [TestCase]
            public void TestConstructor_NotValidParameter_ExpectException()
            {
                Assert.Throws<Exception>(() => new Circle(-5));
            }
            [TestCase]
            public void TestSquare_InputIs5_ExpectEqual()
            {
                Circle circle = new Circle(5);
                Assert.AreEqual(Math.PI * 5 * 5, circle.Square(),0.0001d);
            }
            [TestCase]
            public void TestLength_InputIs10_ExpectEqual()
            {
                Circle circle = new Circle(10);
                Assert.AreEqual(Math.PI * 2 * 10, circle.Length(), 0.0001d);
            }
        }

        [TestFixture]
        class TestTask4
        {
            [TestCase]
            public void TestPerimetr_NotValidParameter_ExpectException()
            {
                Assert.Throws<Exception>(() => StaticClasses.Rectangle.Perimetr(new Point(-2, 10), new Point(-10, 1)));
            }
            [TestCase]
            public void TestPerimetr_ValidParameter_ExpectEqual()
            {
                Assert.AreEqual(18,StaticClasses.Rectangle.Perimetr(new Point(-2, 2), new Point(5, 0)));
            }
            [TestCase]
            public void TestSquare_NotValidParameter_ExpectException()
            {
                Assert.Throws<Exception>(() => StaticClasses.Rectangle.Square(new Point(-2, 10), new Point(-10, 1)));
            }
            [TestCase]
            public void TestSquare_ValidParameter_ExpectEqual()
            {
                Assert.AreEqual(14, StaticClasses.Rectangle.Square(new Point(-2, 2), new Point(5, 0)));
            }
        }

        [TestFixture]
        class TestTask5
        {
            [TestCase]
            public void TestMultiply_ValidParameter_ExpectEqual()
            {
                ComplexNumber c1 = new ComplexNumber(2, 2);
                ComplexNumber c2 = new ComplexNumber(-2, 7);
                ComplexNumber result = c1 * c2;
                Assert.AreEqual(result.Imaginary, 10);
                Assert.AreEqual(result.Real, -18);
            }
            [TestCase]
            public void TestDivide_NotValidParameter_ExpectException()
            {
                ComplexNumber c1 = new ComplexNumber(2, 2);
                ComplexNumber c2 = new ComplexNumber(0, 0);
                try
                {
                    var a = c1 / c2;
                }
                catch(DivideByZeroException ae)
                {
                    Assert.AreEqual(new DivideByZeroException().Message, ae.Message);
                }
            }
            [TestCase]
            public void TestDivide_ValidParameter_ExpectEqual()
            {
                ComplexNumber c1 = new ComplexNumber(1, 1);
                ComplexNumber c2 = new ComplexNumber(1, 1);
                ComplexNumber result = c1 / c2;
                Assert.AreEqual(result.Imaginary,0);
                Assert.AreEqual(result.Real, 1);
            }
        }
    }
}
