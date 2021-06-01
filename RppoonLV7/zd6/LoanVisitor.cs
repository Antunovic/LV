namespace zd6
{
    class LoanVisitor : IVisitor
    {
        private const double DVDTax = 0.18;
        private const double VHSTax = 0.10;
        private const double BookTax = 0.20;
        public double Visit(DVD DVDItem)
        {
            if (DVDItem.Type == DVDType.SOFTWARE)
            {
                return double.NaN;
            }
            return DVDItem.Price * (0.1 + DVDTax);
        }

        public double Visit(VHS VHSItem)
        {
            return VHSItem.Price * (0.1 + VHSTax);
        }

        public double Visit(Book bookItem)
        {
            return bookItem.Price * (0.1 + BookTax);
        }
    }
}
