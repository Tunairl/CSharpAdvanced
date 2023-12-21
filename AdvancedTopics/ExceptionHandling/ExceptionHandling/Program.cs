namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var api = new YoutubeApi();
                var videos = api.GetVideos("Tuna");
            }
            catch (Exception ex) // FROM MOST GENERIC TO MOST SPECIFIC 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
