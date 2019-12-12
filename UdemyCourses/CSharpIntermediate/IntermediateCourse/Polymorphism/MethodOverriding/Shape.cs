namespace Polymorphism.MethodOverriding
{
    // METHOD OVERRIDING
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }
        
        public virtual string Draw()
        {
            return "Drawing a shape...";
        }
    }
}
