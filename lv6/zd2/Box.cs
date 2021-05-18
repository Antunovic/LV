using System.Collections.Generic;

namespace zd2
{
    class Box : IAbstractCollection
    {
        private List<Product> products;
        public Box() { this.products = new List<Product>(); }
        public Box(List<Product> products)
        {
            this.products = new List<Product>(products.ToArray());
        }
        public void AddProduct(Product product) { this.products.Add(product); }
        public void RemoveProduct(Product product) { this.products.Remove(product); }

        public Product this[int index] { get { return this.products[index]; } }

        public IAbstractIterator GetIterator()
        {
            throw new System.NotImplementedException();
        }

        public int Count { get { return this.products.Count; } }
    }
}
