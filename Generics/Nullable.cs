namespace Generics
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        // value types cannot be null
        public Nullable(T value)
        {
            _value = value;
        }

        // if my object has a value, it returns true. If not, it returns false
        public bool HasValue
        {
            get { return _value != null; }
        }
    }
}
