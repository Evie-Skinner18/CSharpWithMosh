using System.Collections.Generic;

namespace Stack
{
    public class Stack
    {
        private List<object> _thingsInTheStack;

        public void Push(object thing)
        {
            _thingsInTheStack.Add(thing);
        }

        public object Pop()
        {
            var indexOfLastThing = _thingsInTheStack.Count;
            return _thingsInTheStack[indexOfLastThing];
        }

        public void Clear()
        {
            _thingsInTheStack.Clear();
        }
    }
}
