using System;


namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialise a new multidimensional array (array of arrays). This array contains
            // three arrays. Each one of those arrays contains five items inside. Rectangular
            var matrix = new int[3, 5]
            {
                {10, 45, 77, 143, 96},
                {25, 17633, 673, 61, 80},
                {23, 57, 79, 59, 4}
            };

            // should display 77
            //Console.WriteLine(matrix[0,2]);

            var numbers = new[] {1,60,88,104,25};

            // Length
            Console.WriteLine("The length of this array is " + numbers.Length);

            // index of
            var i = Array.IndexOf(numbers, 104);
            Console.WriteLine("The index of 104 is " + i);

            // clear
            // Turns a specified amount of items in the array into default value (so 0 for ints)
            // at the specified index. Here, final item in the array will display as 0 instead of 25
            Array.Clear(numbers, 4, 1);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            // copy



        }
    }
}
