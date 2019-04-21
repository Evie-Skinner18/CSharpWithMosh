using System;
using System.IO;

namespace PathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"/Users/eves/Documents/republic.jpg";


            Console.WriteLine($"Extension of {filePath} is {Path.GetExtension(filePath)}");
            Console.WriteLine($"Filename is {Path.GetFileName(filePath)}");

            Console.WriteLine($"It is {Path.IsPathFullyQualified(filePath)} that the file path is fully qualified");
            Console.WriteLine($"Directory is {Path.GetDirectoryName(filePath)}");
        }
    }
}
