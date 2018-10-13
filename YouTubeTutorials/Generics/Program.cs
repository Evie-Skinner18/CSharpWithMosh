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
            Console.WriteLine(bookCollection.Count);
            
            // calling the Nullable that takes a type. In this case we choose the type to be int
            // and the value to be 5.
            var number = new Nullable<int>(5);
            Console.WriteLine("Has value? " + number.HasValue);
            Console.WriteLine("The value is " + number.GetValueOrDefault());
            Console.ReadKey(); 
            
        }
    }
}
