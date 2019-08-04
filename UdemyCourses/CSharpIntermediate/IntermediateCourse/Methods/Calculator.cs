using System.Linq;

namespace Methods
{
    public class Calculator
    {

        // make a method using the params modifier
        public int Add(params int[] numbers)
        {
            return numbers.ToList().Sum();
        }
    }

}
