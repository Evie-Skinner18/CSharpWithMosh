using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace FileReader
{
    public class FileReader
    {
        private readonly string _filePath;

        private int _numberOfWords;

        public FileReader(string filePath)
        {
            // ctor function specifies that when a new FileReader is instantiated, itwill automatically have a file
            // path inside it. Jsut pass in the file path when you create FileReader
            _filePath = filePath;
        }

        // re-usable logic to get all the lines in the file
        public List<string> GetAllFileLines() =>  File.ReadLines(_filePath).ToList();


        // must read a file and display no of words in it
        // how can you improve this to make it handle paragraph spaces when the separator is ' ' ?
        public int GetNumberOfWordsInFile(char separator)
        {
            List<string> words;
            var fileLines = GetAllFileLines();

            foreach (var line in fileLines)
            {
                words = line.Split(separator).ToList();
                words.AddRange(words);
                _numberOfWords += words.Count();
            }

            return _numberOfWords;
        }

        // must display longest word in the file
        public string GetLongestWordInFile()
        {
            List<string> words;
            var fileLines = GetAllFileLines();

            foreach (var item in collection)
            {

            }
        }
    }
}
