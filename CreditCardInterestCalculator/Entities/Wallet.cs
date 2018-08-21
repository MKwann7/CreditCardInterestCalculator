using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCardInterestCalculator.Interfaces;

namespace CreditCardInterestCalculator.Entities
{
    public class Wallet : IWallet
    {
        public string Title { get; set; }

        public bool IsDefault { get; set; }

        public List<CreditCard> CreditCards = new List<CreditCard>();

        public double GetTotalInterestFromAllCreditCards()
        {
            double dcmTotalCreditCardInterest = 0;

            if (CreditCards.Count() == 0)
            {
                return dcmTotalCreditCardInterest;
            }

            foreach (CreditCard curCreditCard in CreditCards)
            {
                dcmTotalCreditCardInterest += curCreditCard.GetSimpleInterest();
            }

            return dcmTotalCreditCardInterest;
        }
    }
}
