using System;

namespace Inheritance
{
    // in c#, a class can haveo nly one parent
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine($"Link added to {url}");
        }
    }
}
