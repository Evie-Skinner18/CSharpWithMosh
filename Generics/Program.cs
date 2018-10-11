using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // any type can be passed to a generic: there's no limitation. this is good like here
            // the list. Sometimes it's not what you need though
            var theJungleBook = new Book {Isbn = 12345, Title = "The Jungle Book"};
            var bookCollection = new List<Book>();
            bookCollection.Add(theJungleBook);
        
            Console.ReadKey();
        }
    }
}
