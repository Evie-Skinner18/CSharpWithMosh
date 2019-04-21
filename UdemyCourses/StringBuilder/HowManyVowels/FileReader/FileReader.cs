using System;
using System.IO;


namespace FileReader
{
    public class FileReader
    {
        public FileInfo FileInfo { get; set; }

        public string FilePath { get; set; }

        public FileReader(string filePath)
        {
            // ctor function specifies that when a new FileReader is instantiated, itwill automatically have a file
            // info object inside it. Jsut pass in the file path when you create FileReader
            filePath = FilePath;
            FileInfo = new FileInfo(filePath);
        }

        // must read a file and display no of words in it
        public int GetNumberOfWordsInFile()
        {
            
        }

        // must display longest word in the file
    }
}
