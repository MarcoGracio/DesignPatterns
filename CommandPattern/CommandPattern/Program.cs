using System;

namespace CommandPattern
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Text Editor!");

            var openFileCommand = new OpenFileCommand("helloworld.txt");
            
            var toolBar = new InvokerToolBar(openFileCommand);
            toolBar.ExecuteCommandClick();
            //VS
            openFileCommand.Execute();



            //-------------------------------


            var printCommand = new PrintCommand(DateTime.Now, new ClipBoard());
            
            toolBar = new InvokerToolBar(printCommand);
            toolBar.ExecuteCommandClick();
            //VS
            printCommand.Execute();

        }
    }
}
