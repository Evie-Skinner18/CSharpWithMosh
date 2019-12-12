using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to Evie's Stack!");

            var stack = new Stack();
            stack.Push("Woof woof!");
            stack.Push("Myaow myaow");
            stack.Push(false);

            stack.Clear();

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }
}
