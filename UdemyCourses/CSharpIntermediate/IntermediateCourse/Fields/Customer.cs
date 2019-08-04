using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;


        //default ctor initialises empty list of orders
        public Customer()
        {
            Orders = new List<Order>();
        }

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
            // you already have a list of orders initliaised by default
            // in the Customer ctor. what if you accidentally re-initialise it?

        }
    }
}
