using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;

        // set it to readonly because it should only be initialised once
        public readonly List<Order> Orders = new List<Order>();


        //default ctor initialises empty list of orders
        //public Customer()
        //{
        //    Orders = new List<Order>();
        //}

        public Customer(int id)
        {
            this.Id = id;
        }

        // this ctor 3 will call ctor 2 in order to get the id, and then take care of name itself
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }

        // they can get promoted to gold customer!
        public void Promote()
        {
            // cannot reinitialise Orders
        }
    }
}
