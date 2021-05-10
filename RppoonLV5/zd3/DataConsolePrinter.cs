using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace zd3
{
    static class DataConsolePrinter
    {


        public static void PrintData(ReadOnlyCollection<List<string>> data)
        {
            foreach (var row in data)
            {
                foreach (string inf in row)
                {
                    Console.Write(inf);
                }
                Console.WriteLine("\n");
            }
        }

    }

}
