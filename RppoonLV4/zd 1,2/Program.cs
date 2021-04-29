using System;

namespace zd1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset dataset = new Dataset(@"C:\\Users\\Antunovic\\source\\repos\\RppoonLV4\\zd1\\bin\\Debug\\net5.0\\csv.txt");

            Adapter adapter = new Adapter(new Analyzer3rdParty());

            Console.WriteLine($"average rows: {adapter.CalculateAveragePerRow(dataset)}");

            Console.WriteLine($"average colums: {adapter.CalculateAveragePerColumn(dataset)}");


        }
    }
}
