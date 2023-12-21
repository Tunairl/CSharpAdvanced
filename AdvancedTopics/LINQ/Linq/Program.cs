namespace Linq
{

    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            // LINQ Extension Methods
            books.Where();
            books.Single();
            books.SingleOrDefault();

            books.First();
            books.FirstOrDefault();

            books.Last();
            books.LastOrDefault();

            books.Min();
            books.Max();
            books.Count();
            books.Sum();
            books.Average(b => b.Price);

            books.Skip(1).Take(3);
           
        }
    }
}