using System;
using System.Collections.Generic;

namespace zd3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRentable> multimedia = new List<IRentable>();

            multimedia.Add(new Book("zlocin i kazna"));
            multimedia.Add(new Video("youtube"));

            RentingConsolePrinter rentingConsolePrinter = new RentingConsolePrinter();

            rentingConsolePrinter.DisplayItems(multimedia);
        }
    }
}
