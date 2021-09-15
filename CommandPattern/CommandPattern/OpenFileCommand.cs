using System;

namespace CommandPattern
{
    partial class Program
    {
        class OpenFileCommand : IButtonCommand
        {
            public string fileName{ get; set; }
            public OpenFileCommand(string fileName)
            {
                this.fileName = fileName;
            }

            public void Execute()
            {
                Console.WriteLine("Opening file:" + fileName);
            }
        }

    }
}
