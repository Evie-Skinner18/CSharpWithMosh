using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            // name is the key and Eves is value
            cookie["name"] = "Eves";

            // this prints Eves
            Console.WriteLine(cookie["name"]);
        }
    }
}
