using System;

namespace Generics
{
    public class Nullable<T> where T : struct //(Value Type)
    {
        private object _value;

        public bool HasValue
        {
            get { return _value != null; }
        }

        public Nullable()
        {
        }

        public Nullable(T value)
        {
            _value = value;
        }

        public T getValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value;
            }

            return default(T);
        }
    }
}
