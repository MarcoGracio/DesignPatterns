using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //1º scenario: every time it needs to process parser it has to "new up" the book parser (high processing cost) and then call process parser
 
            var book = new BookParser(); // take long time to process
            var nr = book.GetNrPages();

            //imagine the follwoing code in other place in the code
            var bookX = new BookParser(); // take long time to process
            var nr2 = bookX.GetNrPages();




            //2º scenario: with proxy
            var book2 = new LazyBookParserProxy(); // take NO time
            var nr3 = book2.GetNrPages(); //internally newup the bookparser (take long time)

            //imagine the follwoing code in other place in the code
            var bookX2 = new LazyBookParserProxy(); // take NO time
            var nr4 = bookX2.GetNrPages();

        }
    }

    interface IBookParser
    {
        int GetNrPages();
    }
    class BookParser : IBookParser
    {
        public BookParser()
        {
            //take a lot of time to process this.....
        }
        public int GetNrPages()
        {
            return 30;
        }
    }

    class LazyBookParserProxy : IBookParser
    {
        BookParser bookParser = null;
        public int GetNrPages()
        {
            if (bookParser == null)
                bookParser = new BookParser();
            return bookParser.GetNrPages();
        }
    }
}
