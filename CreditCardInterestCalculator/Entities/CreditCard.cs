using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCardInterestCalculator.Interfaces;

namespace CreditCardInterestCalculator.Entities
{
    public class CreditCard : ICreditCard
    {
        public string NameOnCard { get; set; }

        public long CreditCardNumber { get; set; }

        public int ExpirationDateMonth { get; set; }

        public int ExpirationDateYear { get; set; }

        public string CardType { get; set; }

        public double CardBallance { get; set; }

        public double CardInterest { get; set; }

        public double GetSimpleInterest()
        {
            CaclulateSimpleInterest();

            return CardInterest;
        }

        private void CaclulateSimpleInterest()
        {
            if (CardBallance.ToString() == "" || CardBallance == 0)
            {
                CardInterest = 0;
                return;
            }

            double dblCardInterestRateValue = GetCardInterestRate(CardType);

            double dblCardInterestRate = dblCardInterestRateValue / 100;

            double intSimpleInterest = CardBallance * dblCardInterestRate;

            CardInterest = intSimpleInterest;
        }

        private double GetCardInterestRate(string strCardType)
        {
            double dblCardInterestRate = 0;

            if (strCardType == "")
            {
                return dblCardInterestRate;
            }

            switch(strCardType.ToLower())
            {
                case "mastercard":
                    dblCardInterestRate = 5;
                    break;
                case "discover":
                    dblCardInterestRate = 1;
                    break;
                default:
                    dblCardInterestRate = 10;
                    break;
            }

            return dblCardInterestRate;
        }
    }
}
