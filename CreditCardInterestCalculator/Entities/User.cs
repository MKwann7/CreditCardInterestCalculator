using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCardInterestCalculator.Interfaces;

namespace CreditCardInterestCalculator.Entities
{
    public class User : IUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public List<Wallet> Wallets = new List<Wallet>();

        public double GetTotalInterestFromAllUserCreditCards()
        {
            double dcmTotalCreditCardInterest = 0;

            if (Wallets.Count() == 0)
            {
                return dcmTotalCreditCardInterest;
            }

            foreach (Wallet curWallet in Wallets)
            {
                dcmTotalCreditCardInterest += curWallet.GetTotalInterestFromAllCreditCards();
            }

            return dcmTotalCreditCardInterest;
        }

        public List<double> GetTotalInterestFromUserCreditCardsByWallet()
        {
            List<double> lstTotalWalletInterestFromCreditCards = new List<double>();

            foreach (Wallet curWallet in Wallets)
            {
                lstTotalWalletInterestFromCreditCards.Add(curWallet.GetTotalInterestFromAllCreditCards());
            }

            return lstTotalWalletInterestFromCreditCards;
        }
    }
}
