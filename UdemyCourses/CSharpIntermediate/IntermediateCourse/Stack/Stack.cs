using System;
using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private List<object> _thingsInTheStack;

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
            var indexOfLastThing = _thingsInTheStack.Count;

            return (indexOfLastThing.Equals(0) || indexOfLastThing.Equals(null))? 
                new InvalidOperationException("Sorry but you can't Pop anything from a stack with nothing in it!") 
                : _thingsInTheStack[indexOfLastThing];
        }

        public void Clear()
        {
            _thingsInTheStack.Clear();
        }
    }
}
