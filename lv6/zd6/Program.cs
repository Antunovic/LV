using System;

namespace zd6
{
    class Program
    {
        static void Main(string[] args)
        {
            StringChecker stringChecker = new StringDigitChecker();

            Console.WriteLine(stringChecker.Check("AAAa44"));
        }
    }
}
