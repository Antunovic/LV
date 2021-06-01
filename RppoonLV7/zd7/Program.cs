using System;
using System.Collections.Generic;

namespace zd7
{

    public enum DVDType { SOFTWARE, MOVIE }
    class Program
    {
        static void Main(string[] args)
        {
            IItem vhs = new VHS("razvoj", 3.22);
            IItem dvd = new DVD("rrpoon", DVDType.MOVIE, 4.33);
            IItem book = new Book("ferit", 5.22);
            IItem software = new DVD("visual studio", DVDType.SOFTWARE, 10.44);

            IVisitor visitor=new 

            Cart cart = new Cart();
            cart.Add(vhs);
            cart.Add(dvd);
            cart.Add(book);
            cart.Add(software);

            cart.Accept()
        }
    }

    class Cart : IItem
    {
        List<IItem> items;
        public Cart()
        {
            items = new List<IItem>();
        }
        public void Add(IItem item)
        {
            items.Add(item);
        }
        public void Remove(IItem item)
        {
            items.RemoveAll(it => it == item);
        }
        public double Accept(IVisitor visitor)
        {
            double sum = 0;
            foreach (var item in items)
            {
                sum += item.Accept(visitor);
            }
            return sum;
        }
    }
}
