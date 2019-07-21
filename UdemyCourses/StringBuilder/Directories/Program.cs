using System;
using System.IO;
using System.Linq;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var newDir = @"/Users/eves/Documents/new_dir";
            Directory.CreateDirectory(newDir);

            Console.WriteLine($"Directory {newDir} has been created");

            var mummy_files = Directory.GetFiles(@"/Users/eves/Documents/mummy_coding", "*.*", SearchOption.AllDirectories);
            var mummy_directories = Directory.GetDirectories(@"/Users/eves/Documents/mummy_coding");

            Console.WriteLine("In the mummy_coding directory I have found...");

            foreach (var file in mummy_files)
            {
                Console.WriteLine(file);
            }

            foreach(var dir in mummy_directories)
                Console.WriteLine(dir);

            var directoryInfo = new DirectoryInfo(@"/Users/eves/Documents/mummy_coding");
            var files = directoryInfo.EnumerateFiles();

        }
    }
}
