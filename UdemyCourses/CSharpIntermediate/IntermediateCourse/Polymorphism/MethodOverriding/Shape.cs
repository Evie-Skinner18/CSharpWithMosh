namespace Polymorphism.MethodOverriding
{
    // METHOD OVERRIDING
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public abstract string Draw();

        public string Copy()
        {
            return "Copying shape...";
        }
        
    }
}
