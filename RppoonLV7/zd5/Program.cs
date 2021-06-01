using System;

namespace zd5
{
    class Program
    {
        static void Main(string[] args)
        {
            IItem vhs = new VHS("razvoj", 3.22);
            IItem dvd = new DVD("rrpoon", DVDType.MOVIE, 4.33);
            IItem book = new Book("ferit", 5.22);

            IVisitor visitor = new BuyVisitor();

            Console.WriteLine(book.Accept(visitor));

        }
    }

    public enum DVDType { SOFTWARE, MOVIE }
}
