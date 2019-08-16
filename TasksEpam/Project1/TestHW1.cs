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
        [TestCase]
        public void Task1_TestPerimetr_InputIs0_ReturnTrue()
        {
            Task1 rectangle = new Task1(new Point(), new Point());
            Assert.AreEqual(0, rectangle.Perimetr());
        }
        [TestCase]
        public void Task1_TestPerimetr_ValidParams_ReturnTrue()
        {
            Task1 rectangle = new Task1(new Point(0, 4), new Point(5, 1));
            Assert.AreEqual(16, rectangle.Perimetr());
        }
        [TestCase]
        public void Task1_TestSquare_InputIs0_ReturnTrue()
        {
            Task1 rectangle = new Task1(new Point(), new Point());
            Assert.AreEqual(0, rectangle.Square());
        }
        [TestCase]
        public void Task1_TestProperties_ValidParams_ReturnTrue()
        {
            Task1 rectangle = new Task1(new Point(-2, 3), new Point(7, 0));
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
            Assert.Throws<Exception>(() => new Task1(new Point(6, 4), new Point(5, 1)));
        }
    }
}
