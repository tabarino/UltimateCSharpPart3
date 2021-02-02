using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1) Define a delegate (This is the agreement between the publisher and the subscriber)
        // 2) Define an event based on that delegate
        // 3) Raise or Publish the event

        // public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        // public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        // public event VideoEncodedEventHandler VideoEncoded;
        // public event EventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // This is a convention in dotnet that Event Publisher Methods should be protected, virtual and void
        // They should start with the word "On" and the name of the Event (VideoEncoded)
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                // VideoEncoded(this, EventArgs.Empty);
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}
