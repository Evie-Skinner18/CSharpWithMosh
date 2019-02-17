using System;
using System.Text;

namespace StringBuilder
{
    class Program
    {
        // using string builder can be more efficient for the memory
        static void Main(string[] args)
        {
            // what's the matter with this why's it not using the namespace??
            var builder = new System.Text.StringBuilder("BIIIIYYYTCH");

            // append and other methods return a string builder object so you can easily chain methods together
            builder.Append('-', 10)
                    .AppendLine()
                    .Append("Herro!")
                    .AppendLine()
                    .Append('*', 20)
                    .Replace('-', '+')
                    .Remove(3, 6)
                    .Insert(0, new string('>', 4));

            Console.WriteLine(builder);
            Console.WriteLine($"First char in the string builder: {builder[0]}");
            Console.ReadKey();
        }
    }
}
