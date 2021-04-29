using System;

namespace zd5
{
    class DiscountedItem : RentableDecorator
    {
        private double discount;

        public DiscountedItem(IRentable rentable,double discount) : base(rentable)
        {
            this.discount = discount;
        }

        public override double CalculatePrice()
        {
            return base.CalculatePrice()*discount;
        }

        public override string Description { get { return $"now at {discount}% off" + base.Description; } }
        
    }
}
