using System;
namespace TasksEpam.Project2
{
    /*
     * Реалізувати базовий клас Figure з абстрактним методом Draw(). 
     * Створити класи Square та Rectangle (унаслідовані від
     * Figure) в яких перегружена імплементація методу Draw() виводить
     * на консоль назву класу в якому даний метод
     * реалізований.
     */
    abstract class Figure
    {
        public abstract void Draw();
    }
    class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
    class Rectangle : Figure
    {
        public override void Draw()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
