using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;

        /* initialising empty Orders list here so that no matter what ctor method is called,
         * the Orders field will always be initialised to an empty list.
         * READONLY because we can only initialise a readonly field either here directly,
         * or in the ctor. Not in another method like Promote cos otherwise whenever you call Promote
         * it would overwrite what is already in the list of Orders! not ideal!
         */
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // implementation here
        }
    }
}
