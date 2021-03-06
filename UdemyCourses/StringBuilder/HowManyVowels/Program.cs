﻿using System;
using System.Linq;

namespace HowManyVowels
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello there, welcome to the vowel-o-matic! Please enter a word and I will count the number " +
                "of vowels for you");
            var userInput = Console.ReadLine().ToLower();
            var vowelCount = GetVowelCount(userInput);


            Console.WriteLine($"The number of vowels in {userInput} is {vowelCount}. Seeya soon!");
            Console.ReadKey();
        }

        public static int GetVowelCount(string userInput)
        {
            return userInput.Count(c => c.Equals('a') || c.Equals('e') || c.Equals('i') || c.Equals('o')
                                     || c.Equals('u'));

        }
    }
}
