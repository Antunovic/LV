using System;
using System.Collections.Generic;

namespace zd4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> multimedia = new List<IRentable>();

            multimedia.Add(new Book("razvoj"));
            multimedia.Add(new Video("programsek podrske"));
            multimedia.Add(new HotItem(new Book("objektno")));
            multimedia.Add(new HotItem(new Video("o nacelima")));

            RentingConsolePrinter rentingConsolePrinter = new RentingConsolePrinter();

            rentingConsolePrinter.DisplayItems(multimedia);
        }
    }
}
