namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very very very long blog post.";
            var shortenedPost = post.Shorten(8);

            IEnumerable<int> numbers = new List<int>() { 1, 5, 2, 3, 10, 19 };
            var max = numbers.Max();

            Console.WriteLine(shortenedPost);
            Console.WriteLine(max);
        }
    }
}