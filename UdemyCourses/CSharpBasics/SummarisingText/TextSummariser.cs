using System;
using System.Linq;
using System.Collections.Generic;

namespace SummarisingText
{
    public class TextSummariser
    {

        public string SummariseText(string sentence, int maxLength)
        {
            if (sentence.Length < maxLength)
                return sentence;

            var words = sentence.Split(' ').ToList();
            var totalChars = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalChars += word.Length + 1;
                if (totalChars > maxLength)
                    break;
            }

            var summaryOfLongSentence = String.Join(" ", summaryWords) + "...";
            return summaryOfLongSentence;
        }
    }
}
