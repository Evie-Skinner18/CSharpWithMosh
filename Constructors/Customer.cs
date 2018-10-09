using System.Collections.Generic;

namespace Constructors
{
    /*a ctor is a method that is called when an instance of a class is created (it's like initialize)
     also like initialize, a ctor is not essential to a class. You only want a ctor method if
     you need the class to have something particular early on. you don't always need to initialise
     an object at an early state!*/
    public class Customer
    {

        // public is not best way to declare fields but we'll see betterway when we get to Properties
        public int Id;
        public string Name;
        // in this List we can store objects of type Order
        public List<Order> Orders;

        /* we can overload the class by having more than one ctor! This means the way that we
        instantiate an object can be flexible. We have three ctors here so can create a Customer
        that has an id, or one that has both id and name, or one that has neither
            */
        public Customer(int id)
        {
            this.Id = id;

        }
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        //default ctor with no parameters
        public Customer()
        {

        }
    } // end of Customer class

}
