namespace TasksEpam.Project1
{
    class RectangleProperties
    {
        //LT = left top 
        //RB = right bottom
        public Point LT { get; set; }
        public Point RB { get; set; }
        readonly double a;
        readonly double b;
        
        public RectangleProperties()
        {
            this.LT = new Point();
            this.RB = new Point();
        }
        public RectangleProperties(Point left_top, Point right_bottom)
        {
            if (left_top.X > right_bottom.X || left_top.Y < right_bottom.Y)
            {
                throw new System.Exception();
            }
            else
            {
                this.LT = left_top;
                this.RB = right_bottom;
                a = RB.X - LT.X;
                b = LT.Y - RB.Y;
            }
        }

        public double Perimetr => (a + b) * 2;
        public double Square => a * b;

        public override string ToString() => $"{LT} {RB}";

    }
}
