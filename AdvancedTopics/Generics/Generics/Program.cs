namespace Generics
{

    class Program
    {
        static void Main(string[] args)
        {
            var number = new Nullable<int>();
            Console.WriteLine("HasValue?: " + number.HasValue);
            Console.WriteLine("Value: " + number.GetValueOrDefault());

        }
    }
}