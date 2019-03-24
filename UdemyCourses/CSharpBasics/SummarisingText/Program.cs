using System;
using System.Collections.Generic;
using System.Linq;

namespace SummarisingText
{
    class Program
    {
        static void Main(string[] args)
        {
            var summariser = new TextSummariser();
            var textSummary = summariser.SummariseText
                ("I LOVE to play the drums all day and all night BAYBAYYYYYYYYAYAYYAAYAYAYAYAYAYAAHHHHHH", 30);
            Console.WriteLine(textSummary);

            Console.ReadKey();
        }
    }
}
