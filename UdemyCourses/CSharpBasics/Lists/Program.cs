using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lists are dynamic in length unlike arrays. List is a gneeric

            // you can add as many objects as you like and the contianer will grow to fit these things inside
            var nums = new List<int>()
            {
                1,
                2,
                3,
                4
            };
            nums.Add(1);

            // add another Enumerable to the list. So can be an array or another list!
            nums.AddRange(new int[3] {5, 6, 7});

            foreach (var num in nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine($"The index of the first 1 I've found in nums is {nums.IndexOf(1)}.");
            Console.WriteLine($"The index of the last 1 in nums is {nums.LastIndexOf(1)}.");

            Console.WriteLine($"I've counted the number of items in nums: {nums.Count}");

            // this will remove the first 1 it finds
            nums.Remove(1);
            foreach (var num in nums)
            {
                Console.WriteLine(num);

            }
            Console.ReadKey();

        }
    }
}
