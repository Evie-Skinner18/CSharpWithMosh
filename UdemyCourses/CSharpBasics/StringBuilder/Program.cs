using System;

namespace StringMethods
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

            Console.WriteLine($"Replace: {fullName.Replace("Evie", "Eveline")}");
            Console.WriteLine($"Replace: {fullName.Replace("e", "BITCH")}");
            Console.WriteLine($"Replace: {fullName.Replace("i", "£")}");

            // nul or empty will count a space as a valid string so it's not always reliable
            // you can count on null or whitespace!
            if(String.IsNullOrEmpty(" "))
                Console.WriteLine( "This is invalid soz!");
            if(String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("This is invalid soz!");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            var realPrice = price.ToString("C0");
            // how does it get the £ sign?
            Console.WriteLine(realPrice);

            Console.ReadKey();
        }
    }
}
