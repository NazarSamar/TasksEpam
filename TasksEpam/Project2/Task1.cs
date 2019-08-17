namespace TasksEpam.Project2
{
    abstract class Figure
    {
        public abstract void Draw();
    }
    class Square : Figure
    {
        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
    class Rectangle : Figure
    {
        public override void Draw()
        {
            throw new System.NotImplementedException();
        }
    }
}
