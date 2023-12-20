namespace EventsAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object soruce, VideoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message..." + args.Video.Title);
        }
    }
}