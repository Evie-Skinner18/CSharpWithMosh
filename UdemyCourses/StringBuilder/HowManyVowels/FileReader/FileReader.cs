using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


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
        public int GetNumberOfWordsInFile(char separator)
        {
            //var stream = FileInfo.OpenRead();
            int numberOfWords;
            List<string> fileWords;

            var fileLines = File.ReadLines(FilePath).ToList();
            //var fileWords = fileLines.ForEach(l => l.Split(separator));

            foreach (var line in fileLines)
            {
                var words = line.Split(separator).ToList();
                words.AddRange(words);
            }

             

        }

        // must display longest word in the file
    }
}
