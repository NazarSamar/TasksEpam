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
            public void Task1_TestPerimetr_InputIs0_ReturnTrue()
            {
                Rectangle rectangle = new Rectangle(new Point(), new Point());
                Assert.AreEqual(0, rectangle.Perimetr());
            }
            [TestCase]
            public void Task1_TestPerimetr_ValidParams_ReturnTrue()
            {
                Rectangle rectangle = new Rectangle(new Point(0, 4), new Point(5, 1));
                Assert.AreEqual(16, rectangle.Perimetr());
            }
            [TestCase]
            public void Task1_TestSquare_InputIs0_ReturnTrue()
            {
                Rectangle rectangle = new Rectangle(new Point(), new Point());
                Assert.AreEqual(0, rectangle.Square());
            }
            [TestCase]
            public void Task1_TestProperties_ValidParams_ReturnTrue()
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
            public void Task2_TestPerimetr_InputIs0_ReturnTrue()
            {
                RectangleProperties rectangle = new RectangleProperties(new Point(), new Point());
                Assert.AreEqual(0, rectangle.Perimetr);
            }
            [TestCase]
            public void Task2_TestPerimetr_ValidParams_ReturnTrue()
            {
                RectangleProperties rectangle = new RectangleProperties(new Point(-2, 2), new Point(5, 0));
                Assert.AreEqual(18, rectangle.Perimetr);
            }
            [TestCase]
            public void Task2_TestSquare_InputIs0_ReturnTrue()
            {
                RectangleProperties rectangle = new RectangleProperties(new Point(), new Point());
                Assert.AreEqual(0, rectangle.Square);
            }
            [TestCase]
            public void Task2_TestConstructor_NotValidParams_EqualException()
            {
                Assert.Throws<Exception>(() => new RectangleProperties(new Point(-2, 10), new Point(-10, 1)));
            }
        }

        [TestFixture]
        class TestTask3
        {
            [TestCase]
            public void TestConstructor_NotValidParameter_ReturnTrue()
            {
                Assert.Throws<Exception>(() => new Circle(-5));
            }
            [TestCase]
            public void TestSquare_InputIs5_ReturnTrue()
            {
                Circle circle = new Circle(5);
                Assert.AreEqual(Math.PI * 5 * 5, circle.Square(),0.0001d);
            }
            [TestCase]
            public void TestLength_InputIs10_ReturnTrue()
            {
                Circle circle = new Circle(10);
                Assert.AreEqual(Math.PI * 2 * 10, circle.Length(), 0.0001d);
            }
        }
    }
}
