using System;

namespace zd6
{

    public enum DVDType { SOFTWARE, MOVIE }
    class Program
    {
        static void Main(string[] args)
        {
            IItem vhs = new VHS("razvoj", 3.22);
            IItem dvd = new DVD("rrpoon", DVDType.MOVIE, 4.33);
            IItem book = new Book("ferit", 5.22);

            IVisitor loanVisitor = new LoanVisitor();
            

            Console.WriteLine(book.Accept(loanVisitor));
        }
    }
}
