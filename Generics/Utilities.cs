using System;

namespace Generics
{
    // where T : IComparable
    // where T : Product (One class and all its children)
    // where T : struct (Value Type)
    // where T : class (Reference Type)
    // where T : new() (Default constructor)

    // public class Utilities
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // Generic version of the Max method
        // It can also be in this way
        // public T MaxGeneric<T>(T a, T b) where T : IComparable
        public T MaxGeneric(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            // We can only use this line here because of the new() in the definition of the class
            var obj = new T();
        }
    }
}
