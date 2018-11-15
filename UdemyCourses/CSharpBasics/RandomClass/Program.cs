using System;
using System.Text;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var buffer = new char[10];



            for (int i = 0; i < 10; i++)
            {
                // the console will show ten random ASCII chars whose numbers are between 0 and 26 after
                // the char 'a'. this equates to alphabet! Make the range of numbers wider for alphanumeric
                // . Make a random password
                buffer[i] = (char)('a' + random.Next(0, 50));
            }
            // you can create a new string by passig in an array of chars as argument
            var password = new string(buffer);
            Console.WriteLine(password);

            // 97 represents the char a in a computer. ASCII
            // Console.WriteLine((int) 'a');
            Console.ReadKey();
        }
    }
}
