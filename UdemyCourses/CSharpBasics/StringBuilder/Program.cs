using System;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Evie Skinner ";
            var index = fullName.IndexOf(' ');
            var names = fullName.Split(' ');

            Console.WriteLine("Trim: '{0}'",fullName.Trim());
            Console.WriteLine(  $"To upper: {fullName.ToUpper()}");
            Console.WriteLine($"Substring: {fullName.Substring(0, index)}");
            Console.WriteLine($"Split: {names[0]}");
            Console.WriteLine($"Split: {names[1]}");
        }
    }
}
