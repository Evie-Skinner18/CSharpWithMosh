namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //one Move method
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // we can overload the Movemethod by making another one that takes a different signature,
        // like a Point object
        public void Move(Point newLocation)
        {
            this.X = newLocation.X;
            this.Y = newLocation.Y;
        }
    }
}
