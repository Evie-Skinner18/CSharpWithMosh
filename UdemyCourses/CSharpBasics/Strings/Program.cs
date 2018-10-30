using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Jimbo";
            string lastName = "Da Formagge";

            var fullName = string.Format("My name is {0} {1}", firstName, lastName);

            string [] names = {"Evie", "Nelly", "Jimbo", "Mobwicks"};
            var formattedNames = string.Join(" and ", names);

            // @ means it's a 
            var text = @"Hi John,
                Look into the following paths: 
                \Users\eves\bitch
                \bitch\bitch\bitch
                
                Ta, love you  :->";
                
            Console.WriteLine(fullName);
            Console.WriteLine(formattedNames);
            Console.WriteLine(text);
        }
    }
}
