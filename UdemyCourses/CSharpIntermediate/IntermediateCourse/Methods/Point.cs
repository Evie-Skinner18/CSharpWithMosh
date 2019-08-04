namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(Point newLocation)
        {
            X = newLocation.X;
            Y = newLocation.Y;
        }
    }
}
