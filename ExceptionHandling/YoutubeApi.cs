using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    public class YoutubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                // Access Youtube Webservice
                // Read the data
                // Create a list of Video Objects

                throw new Exception("Test Youtube Exception");
            }
            catch (Exception ex)
            {
                throw new YoutubeException("Could not fetch the videos from Youtube", ex);
            }

            return new List<Video>();
        }
    }
}
