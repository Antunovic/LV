namespace zd2
{
    static class ShippingService
    {
        private static double pricePerKg = 2;

        public static double CalculatePrice(IShipable box)
        {
            return box.Weight * pricePerKg;
        }

    }
}
