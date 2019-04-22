using System;
using System.IO;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there file friend! I am going to count the number of words in this file for you.");
            var filePath = @"/Users/eves/file_challenges.txt";

            Console.WriteLine($"The file path is {filePath} and it is {File.Exists(filePath)} that it exists");
            var fileReader = new FileReader(filePath);

            Console.WriteLine($"The number of words in this file is {fileReader.GetNumberOfWordsInFile(' ')}");

            Console.WriteLine($"The longest word in this file is {fileReader.GetLongestWordInFile(' ')}");


        }
    }
}
