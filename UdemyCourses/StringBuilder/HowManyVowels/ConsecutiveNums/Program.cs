using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsecutiveNums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the consecutive number checker!Please enter a few numbers separated by" +
            	" hyphens and I will check them for you.");
            var userInput = Console.ReadLine().Split('-').ToList();
            var listOfNums = new List<int>();
            int convertedNum;

            //var num = 0;
            bool isConsecutive;
            string message; 

            foreach (var str in userInput)
            {
                convertedNum = Int32.Parse(str);
                listOfNums.Add(convertedNum);
            }

            foreach (var num in listOfNums)
            {
                isConsecutive = listOfNums[num] == listOfNums[num - 1] + 1 || listOfNums[num] == listOfNums[num - 1] - 1;
                message = isConsecutive ? "The numbers you entered are consecutive!" : "Not consecutive";
            }



        }
    }
}
