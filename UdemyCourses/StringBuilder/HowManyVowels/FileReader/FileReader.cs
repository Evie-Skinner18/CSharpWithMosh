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

        private List<string> _words;

        public FileReader(string filePath)
        {
            // ctor function specifies that when a new FileReader is instantiated, itwill automatically have a file
            // path inside it. Jsut pass in the file path when you create FileReader
            _filePath = filePath;
        }

        // re-usable logic to get all the lines in the file
        private List<string> GetAllFileLines() =>  File.ReadLines(_filePath).ToList();

        // re-usable logic to remove punctuation
        private List<string> RemoveAllPunctuation(List<string> words)
        {
            if (words.Contains(",") || words.Contains("-") || words.Contains("!") || words.Contains("."))
            {
                foreach (var word in words)
                {
                    word.Replace(",", string.Empty);
                    word.Replace("-", string.Empty);
                    word.Replace("!", string.Empty);
                    word.Replace(".", string.Empty);
                }
                return words;
            }

            return words;
        }


        // must read a file and display no of words in it
        // how can you improve this to make it handle paragraph spaces when the separator is ' ' ?
        public int GetNumberOfWordsInFile(char separator)
        {
            var fileLines = GetAllFileLines();

            foreach (var line in fileLines)
            {
                _words = line.Split(separator).ToList();
                _words.AddRange(_words);
                _numberOfWords += _words.Count();
            }

            return _numberOfWords;
        }

        // must display longest word in the file
        public string GetLongestWordInFile(char separator)
        {
       
            var fileLines = GetAllFileLines();

            foreach (var line in fileLines)
            {
                _words = line.Split(separator).ToList();
                _words = RemoveAllPunctuation(_words);
            }

            return _words.OrderByDescending(w => w.Length).FirstOrDefault();
        }
    }
}
