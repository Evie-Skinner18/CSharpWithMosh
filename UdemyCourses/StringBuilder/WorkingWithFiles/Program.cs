using System;
using System.IO;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // File static methods. Every time you call one, the OS does some security checking which has implications
            // for performance of your app
            var jimboFile = @"/Users/eves/Documents/JimboCoverLetter.docx";

            // in a verbatime string using @, you don't need to put double backslashes
            File.Copy(@"/Users/eves/Documents/uplifter19.jpg", @"/Users/eves/Documents/evie/uplifter19.jpg", true);
            Console.WriteLine("The file has been copied");

            //File.Delete(@"/Users/eves/Documents/evie/uplifter19.jpg");
            //Console.WriteLine("The file has been deleted");

            if (File.Exists(@"/Users/eves/Documents/evie/uplifter19.jpg"))
            {
                File.Open(@"/Users/eves/Documents/evie/uplifter19.jpg", mode: FileMode.Open);
                Console.WriteLine("The file has been opened");
            }

            var content = File.ReadAllText(jimboFile);
            Console.WriteLine("The file has been read");

            // FileInfo instance methods. OS checks security only once when a new fileInfo obj is created
            var fileInfo = new FileInfo(jimboFile);
            var newFile = File.Create(@"/Users/eves/Documents/new_file.txt").ToString();
            fileInfo.CopyTo(newFile, true);
            Console.WriteLine($"The file info has been copied to the new file");

            // Delete JimboCoverLetter
            // fileInfo.Delete();



        }
    }
}
