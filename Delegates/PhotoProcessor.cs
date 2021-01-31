using System;

namespace Delegates
{
    public class PhotoProcessor
    {
        // Dotnet has its own delegates. So, we do not need to create ours
        // public delegate void  PhotoFilterHandler(Photo photo);

        // Action<> -> Action points to a method that retuns void
        // Func<> -> Func points to a method that returns a values



        // public void Process(string path, PhotoFilterHandler filterHandler)
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}
