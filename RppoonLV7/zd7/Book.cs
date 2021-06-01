namespace zd7
{
    class Book : IItem
    {
        public string Title { get; private set; }
        public double Price { get; private set; }

        public Book(string title,double price)
        {
            this.Title = title;
            this.Price = price;

        }

        public double Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
