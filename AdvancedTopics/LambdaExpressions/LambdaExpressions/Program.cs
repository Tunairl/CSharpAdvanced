namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression
            // => "goes to"

            // () => ... (if we dont need an argument)
            // x => ... (just one argument)
            // (x, y, z) => ... (multiple args)

            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10); // there used to be an IsCheaperThan10Dollars method between FindAll parameter

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}