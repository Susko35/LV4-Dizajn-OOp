using System;
using System.Collections.Generic;
using System.Text;

namespace LV4_Dizajn_OOP
{
    class DiscountItem : RentableDecorator
    {
        private readonly double DiscountItemMinus = 2.99;
        public DiscountItem(IRentable rentable) : base(rentable) { }
        public override double CalculatePrice()
        {
            return base.CalculatePrice() - this.DiscountItemMinus;
        }
        public override String Description
        {
            get
            {
                return "Discount: " + base.Description;
            }
        }
    }
}
