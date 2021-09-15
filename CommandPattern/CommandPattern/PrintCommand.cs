using System;

namespace CommandPattern
{
    partial class Program
    {
        class PrintCommand : IButtonCommand
        {
            private DateTime timeStamp;
            private ClipBoard clipBoard;
            public PrintCommand(DateTime timeStamp, ClipBoard cb)
            {
                this.timeStamp = timeStamp;
                clipBoard = cb;
            }
            public void Execute()
            {
                Console.WriteLine(this.timeStamp + " : Printing:" + clipBoard.GetValue());
            }
        }
    }
}
