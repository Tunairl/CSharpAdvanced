using System.Runtime.InteropServices;

namespace EventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event

        // #1 delegate
        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // #2 event based on delegate
        // public event VideoEncodedEventHandler VideoEncoded; // Using past tense form, indicating that sth has happened and finished

        // EventHandler
        // EventHandler<TEventArgs>

        // #2 with a predefined eventhandler
        public event EventHandler<VideoEventArgs> VideoEncoded; // in .Net, we have predefined event handler class, so we don't have to
                                                                // create a new delegate each time
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // #3
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}