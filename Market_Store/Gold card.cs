using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_Store 
{
    class Gold_card : Discount_card
    {
        public Gold_card(string firstName, string lastName, float turnover, float valueOfPurchase) : base(firstName, lastName, turnover, valueOfPurchase)
        {

        }

        public override float discountRate()
        {
            try
            {
                switch (turnover)
                {
                    case float x when (x >= 100 && x < 200):
                        initialDiscountRate = 3;
                        break;

                    case float x when (x >= 200 && x < 300):
                        initialDiscountRate = 4;
                        break;

                    case float x when (x >= 300 && x < 400):
                        initialDiscountRate = 5;
                        break;

                    case float x when (x >= 400 && x < 500):
                        initialDiscountRate = 6;
                        break;

                    case float x when (x >= 500 && x < 600):
                        initialDiscountRate = 7;
                        break;

                    case float x when (x >= 600 && x < 700):
                        initialDiscountRate = 8;
                        break;

                    case float x when (x >= 700 && x < 800):
                        initialDiscountRate = 9;
                        break;

                    case float x when (x >= 800):
                        initialDiscountRate = 10;
                        break;

                    default:
                        initialDiscountRate = 2;
                        break;
                }
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
