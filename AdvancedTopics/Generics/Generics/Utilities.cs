namespace Generics
{

    // where T : IComparable -> interface
    // where T : Product -> type, subclasses
    // where T : struct -> value 
    // where T : class -> reference
    // where T : new() -> default ctor
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}