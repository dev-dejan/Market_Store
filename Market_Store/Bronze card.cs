using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Store
{
    class Bronze_card : Discount_card
    {
        public Bronze_card(string firstName, string lastName, float turnover, float valueOfPurchase) : base(firstName, lastName, turnover, valueOfPurchase)
        {

        }
        public override float discountRate()
        {
            try
            {
                if (turnover >= 0 && turnover < 100)
                {
                    initialDiscountRate = 0;
                }
                else if (turnover >= 100 && turnover <= 300) // I asumed that values 100 and 300 are included in the "If it is between $100 and $300" statement
                {
                    initialDiscountRate = 1;
                }
                else if (turnover > 300)
                {
                    initialDiscountRate = (float)2.5;
                }
                else
                    Console.WriteLine("Input can't be a negative number!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return initialDiscountRate;
        }

        public override float discount()
        {
            return base.discount();
        }

        public override float total()
        {
            return base.total();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
