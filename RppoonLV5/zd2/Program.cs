using System;

namespace zd2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box("aliexpres");
            Box electronics = new Box("electronics");

            electronics.Add(new Product("mouse", 23.22, 1.5));
            electronics.Add(new Product("laptop", 243, 3.4));

            box.Add(new Product("lawn mover", 100, 10.5));
            box.Add(electronics);

            Console.WriteLine($"shipping price: ${ShippingService.CalculatePrice(box)}");

            
        }
    }
}
