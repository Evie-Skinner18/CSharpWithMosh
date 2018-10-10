using System;

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

        //one Move method that takes just an x and y. This is FIRST OVERLOAD
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // we can overload the Movemethod by making another one that takes a different signature,
        // like a Point object. So now we have two slightly different ways (OVERLOADS) of invoking the method
        public void Move(Point newLocation)
        {
            /* Don't need to repeat orselves here if we make this Move method invoke the
             * Move method above!
             * 
            this.X = newLocation.X;
            this.Y = newLocation.Y;
             **/

            // if the argument is null, the code will never reach this bit. So te Point object
            // will always bein a valid state. Validating the argument
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            
            Move(newLocation.X, newLocation.Y);
        }
    }
}
