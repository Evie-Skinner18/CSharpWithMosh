using System;

namespace Methods
{
    partial class Program
    {
        public class Calculator
        {
            // got params here so we ca nput as many ints in this array as we like!
            public int Add(params int[] numbers)
            {
                var sum = 0;
                foreach(var num in numbers)
                {
                    // add each num to sum and reassign the total to the value of sum
                    sum += num;
                }
                return sum;
            }
        }
    }
}
