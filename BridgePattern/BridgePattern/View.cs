using System;

namespace BridgePattern
{
    abstract class View
    {
        protected IMediaResource _resource;
        public View(IMediaResource resource)
        {
            this._resource = resource;
        }

        public abstract void Show();
    }

    class LongView : View
    {
        public LongView(IMediaResource resource) : base(resource) { }
        public override void Show()
        {
            Console.WriteLine(_resource.Title() + ": Show long view!");
        }
    }

    class ShortView : View
    {
        public ShortView(IMediaResource resource) : base(resource) { }
        public override void Show()
        {
            Console.WriteLine(_resource.Title() + ": Show short view!");
        }
    }
}
