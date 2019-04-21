using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace FileReader
{
    public class FileReader
    {
        //private FileInfo _fileInfo;

        private string _filePath;

        private int _numberOfWords;

        public FileReader(string filePath)
        {
            // ctor function specifies that when a new FileReader is instantiated, itwill automatically have a file
            // info object inside it. Jsut pass in the file path when you create FileReader
            _filePath = filePath;
            //FileInfo = new FileInfo(filePath);
        }

        // must read a file and display no of words in it
        public int GetNumberOfWordsInFile(char separator)
        {
            //var stream = FileInfo.OpenRead();

            List<string> words;
            
            var fileLines = File.ReadLines(_filePath).ToList();
            //var words = fileLines.ForEach(l => l.Split(separator));

            foreach (var line in fileLines)
            {
                words = line.Split(separator).ToList();
                words.AddRange(words);
                _numberOfWords += words.Count();
            }



            return _numberOfWords;


        }

        // must display longest word in the file
    }
}
