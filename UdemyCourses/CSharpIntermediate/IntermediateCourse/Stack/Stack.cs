using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    public class Stack
    {
        private List<object> _thingsInTheStack;

        public Stack()
        {
            _thingsInTheStack = new List<object>();
        }

        public void Push(object thing)
        {
            if (thing.Equals(null))
            {
                throw new InvalidOperationException("Sorry but you can't add NULL to the stack!");
            }
            else
            {
                _thingsInTheStack.Add(thing);
            }
        }

        public object Pop()
        {
            var lastThingInTheStack = _thingsInTheStack.Count > 0 ? _thingsInTheStack.Last() : null;

            if (_thingsInTheStack.Equals(null) || lastThingInTheStack.Equals(null))
            {
                throw new InvalidOperationException("Sorry but you can't Pop anything from a stack with nothing in it!");
            }          
            else
            {
                _thingsInTheStack.Remove(lastThingInTheStack);
                return lastThingInTheStack;                            
            }
        }

        public void Clear()
        {
            _thingsInTheStack.Clear();
        }
    }
}
