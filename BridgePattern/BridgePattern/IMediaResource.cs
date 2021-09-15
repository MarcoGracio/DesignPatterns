using System;

namespace BridgePattern
{
    interface IMediaResource
    {
        string Title();
    }

    class BookResource : IMediaResource
    {
        public string Title()
        {
            return "Book Title X!!";
        }
    }

    class ArtistResource : IMediaResource
    {
        public string Title()
        {
            return "Artist Title X!!";
        }
    }
}
