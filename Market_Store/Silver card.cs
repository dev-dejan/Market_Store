using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Store
{
    class Silver_card : Discount_card
    {
        public Silver_card(string firstName, string lastName, float turnover, float valueOfPurchase) : base(firstName, lastName, turnover, valueOfPurchase)
        {

        }

        public override float discountRate()
        {
            try
            {
                if (turnover > 300)
                {
                    initialDiscountRate = (float)3.5;
                }
                else
                    initialDiscountRate = 2;
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
