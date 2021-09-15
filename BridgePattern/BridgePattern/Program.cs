using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IMediaResource resource = new BookResource();

            View view = new LongView(resource);
            view.Show();

            view = new ShortView(resource);
            view.Show();


            //
            resource = new ArtistResource();

            view = new LongView(resource);
            view.Show();

            view = new ShortView(resource);
            view.Show();
        }
    }
}
