namespace Generics
// there is actually already a structure (not a class) called Nullable in the System
// namespace but here's a new one!
{
    public class Nullable<T> where T : struct
    {
        private object _value;

        // default ctor in case the value is not set
        public Nullable()
        {
            
        }

        // value types cannot be null. this ctor takes a T we are calling value.
        // specifying a constraint that says T has to be a value type
        public Nullable(T value)
        {
            _value = value;
        }

        // if my object has a value, it returns true. If not, it returns false
        public bool HasValue
        {
            // if _value is not null, return true
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            // If our object is initialised, it returns the value of that obj. Otherwise, it
            // returns the default value of the type, that's the T. so 0 for an int
            if (HasValue)
                return (T) _value;

            return default(T);

        }
    }
}
