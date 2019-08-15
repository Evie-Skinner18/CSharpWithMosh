using System;
using System.Collections.Generic;

namespace IntermediateCourse
{
    public class Customer
    {

        public int Id;
        public string Name;
        public List<Order> Orders;

        // CTOR 1 default ctor
        public Customer()
        {
            Orders = new List<Order>();
        }

        //CTOR 2 another ctor. Using :this() ensures that default ctor will be called before CTOR2 
        public Customer(int id)
            :this()
        {
            this.Id = id;
        }

        // CTOR 3 and another one! When we use CTOR 3, it ensures that CTOR 2 will be called before
        // CTOR 3. CTOR 2 ensures that the default one CTOR 1 will be called before CTOR 2 so all of them will
        // be called
        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
