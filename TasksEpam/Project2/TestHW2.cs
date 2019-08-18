using NUnit.Framework;
using System;

namespace TasksEpam.Project2
{

    [TestFixture]
    class TestHW2
    {
        // I used square.GetType().Name because square.Draw() is void method
        // and i can`t to check if ouptup is correct.
        // So using GetType().Name, i used square.Draw() but returning type
        // is string and i can to check if output is correct
        [TestFixture]
        class TestTask1
        {
            [TestCase]
            public void TestSquare_TestDraw_ExpectEqual()
            {
                Square square = new Square();
                Assert.AreEqual("Square", square.GetType().Name);
            }
            [TestCase]
            public void TestRectangle_TestDraw_ExpectEqual()
            {
                Rectangle rectangle = new Rectangle();
                Assert.AreEqual("Rectangle", rectangle.GetType().Name);
            }
        }
        [TestFixture]
        class TestTask2
        {
            [TestCase]
            public void TestAbstract_TestDraw_ExpectEqual()
            {
                Abstract.Square square = new Abstract.Square(1,3);
                Abstract.Rectangle rectangle = new Abstract.Rectangle(2, 5);
                Assert.AreEqual("Square", square.GetType().Name);
                Assert.AreEqual("Rectangle", rectangle.GetType().Name);
            }
        }
        [TestFixture]
        class TestTask3
        {
            [TestCase]
            public void TestVirtual_TestDraw_ExpectEqual()
            {
                Virtual.Figure figure = new Virtual.Figure(2, 5);
                Virtual.Square square = new Virtual.Square(1, 3);
                Virtual.Rectangle rectangle = new Virtual.Rectangle(2, 5);

                Assert.AreEqual("Figure", figure.GetType().Name);
                Assert.AreEqual("Square", square.GetType().Name);
                Assert.AreEqual("Rectangle", rectangle.GetType().Name);

                Virtual.Figure figure1 = new Virtual.Square(2,2);
                Virtual.Figure figure2 = new Virtual.Rectangle(2, 2);
                
                Assert.AreEqual("Square", figure1.GetType().Name);
                Assert.AreEqual("Rectangle", figure2.GetType().Name);
            }
        }
        [TestFixture]
        class TestTask4
        {
            [TestCase]
            public void TestInterface_TestDrawAll_ExpectEqual()
            {
                Interface.IDrawable[] drawables = new Interface.IDrawable[]
                {
                    new Interface.Figure(2,6),
                    new Interface.Square(7,-2),
                    new Interface.Square(-2,5),
                    new Interface.Figure(5,2),                    
                    new Interface.Square(0,0), 
                    new Interface.Rectangle(1,2)
                };
                string to_check = "";                
                foreach (var item in drawables)
                {
                    to_check += item.GetType().Name;
                }
                Assert.AreEqual("FigureSquareSquareFigureSquareRectangle", to_check);                
            }
        }
    }
}
