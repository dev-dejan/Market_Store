using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Store
{
    class Discount_card
    {
        protected string firstName;
        protected string lastName;
        protected float turnover;
        protected float valueOfPurchase;

        protected float initialDiscountRate;
        protected float currentDiscount;
        protected float discountPrice;

        public Discount_card(string firstName, string lastName, float turnover, float valueOfPurchase)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.turnover = turnover;
            this.valueOfPurchase = valueOfPurchase;
        }

        public virtual float discountRate()
        {
            return initialDiscountRate;
        }

        public virtual float discount()
        {
            currentDiscount = initialDiscountRate * (float)0.01;
            discountPrice = valueOfPurchase * currentDiscount;
            return discountPrice;
        }

        public virtual float total()
        {
            return valueOfPurchase - discountPrice;
        }

        public override string ToString()
        {
            return "Purchase value: $" + valueOfPurchase + "\n" +
                "Discount rate: " + discountRate() + "%" + "\n" +
                "Discount: $" + discount() + "\n" +
                "Total purchase value: $" + total();
        }
    }
}
