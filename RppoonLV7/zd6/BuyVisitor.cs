namespace zd6
{
    class BuyVisitor : IVisitor
    {
        private const double DVDTax = 0.18;
        private const double VHSTax = 0.10;
        private const double bookTax = 0.20;
        public double Visit(DVD DVDItem)
        {
            return DVDItem.Price * (1 + DVDTax);
        }
        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * (1 + DVDTax);
        }

        public double Visit(Book bookItem)
        {
            return bookItem.Price * (1 + bookTax);
        }
    }

}
