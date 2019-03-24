using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion. No loss of data here
            byte myByte = 1;
            int i = myByte;
            Console.WriteLine(i);

            //explcit conversion (typecast). the int here is small enough to be converted fine
            // max you can store in a byte is 255
            int anotherInt = 1;
            byte anotherByte = (byte)anotherInt;

            // non compatible types
            var myString = "1234";
            int myNum = Convert.ToInt32(myString);
            Console.WriteLine(myNum);
            //int myNum = int.Parse(myString);

            try
            {
                //this won't work as 5,678 is too great for a byte to handle
                var number = "5678";
                byte littleByte = Convert.ToByte(number);
                Console.WriteLine(littleByte);
            }
            catch (Exception)
            {
                // let's catch that naughty error!
                Console.WriteLine("this is a friendly error message. Soz that number could not be" +
                    "converted to a byte!");
            }

            try
            {
                string cestVrai = "true";
                bool ouPas = Convert.ToBoolean(cestVrai);
                Console.WriteLine(ouPas);
            }
            catch (Exception)
            {
                // let's catch that naughty error!
                Console.WriteLine("Voici un message d'erreur convivial. Pardon mais la phrase ne" +
                    "peut pas etre convertie en boolean");
            }
            
            Console.ReadKey();
        }
    }
}
