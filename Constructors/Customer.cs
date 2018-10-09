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

        //default ctor with no parameters
        public Customer()
        {
            // DRY
            Orders = new List<Order>();
        }

        /*'this' keyword means that first, the ctor here is going to call the ctor above that has
         * no parameters, which will initialise the Orders field. Then it will run what's inside itself
         */
        public Customer(int id)
            :this()
        {
            // DRY
            this.Id = id;

        }

        /* Here the ctor also has a 'this' keyword. So it too will first call the ctor without
         * parameters which will ensure that any time you instantiate a Customer, it will
         * always have initialised inside it an empty List of Orders. Then it will call the
         * ctor that takes an id paramter, so any Customer will also have an id.
         Now we don't need a this.Id - id field inside the ctor */
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }

    } /* end of Customer class. Its the responsibility of the Customer class to ensure its Orders get initialised
       to an empty List. Otherwise Orders won't get initialised and it'll be null! */

}
