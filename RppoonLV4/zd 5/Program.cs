using System;
using System.Collections.Generic;

namespace zd5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> flashsale = new List<IRentable>();

            flashsale.Add(new DiscountedItem(new Book("zlocin i kazna"), 0.25));
            flashsale.Add(new DiscountedItem(new Video("razvoj"), 0.2));
            flashsale.Add(new HotItem(new Book("neam pojma")));

            RentingConsolePrinter rentingConsolePrinter = new RentingConsolePrinter();

            rentingConsolePrinter.DisplayItems(flashsale);
        }
    }
}
