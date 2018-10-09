using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {   
            // anything inside the placeholder curly braces will be replaced by the arguments after at rutime
            // formatted string
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);

            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            Console.WriteLine("{0} {1}", "Hello", "Bonjour");

            const float Pi = 3.14f;
            Console.WriteLine(Pi);
            Console.ReadKey();
        }
    }
}
