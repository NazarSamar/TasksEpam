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
    }
}
