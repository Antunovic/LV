using System;

namespace zd2
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box();

            box.AddProduct(new Product("mouse", 2.22));
            box.AddProduct(new Product("keyboard", 3.65));
            box.AddProduct(new Product("monitor", 10.22));

            IAbstractIterator iterator = new Iterator(box);

            for(Product product=iterator.First();iterator.IsDone==false; product = iterator.Next())
            {
                Console.WriteLine(product.Description);
            }
        }
    }

}
