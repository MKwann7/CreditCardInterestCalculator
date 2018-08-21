using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCardInterestCalculator.Entities;

namespace CreditCardInterestCalculator.TestingClasses
{
    public class CaseData
    {
        public static User SetupCase1UserInformation()
        {
            User objPerson = new User();

            objPerson.FirstName = "Bob";
            objPerson.LastName = "Smith";
            objPerson.PhoneNumber = "618-555-1234";
            objPerson.EmailAddress = "bob@smithshouse.com";

            Wallet objWallet1 = new Wallet();

            objWallet1.Title = "Main Wallet";
            objWallet1.IsDefault = true;

            CreditCard objVisaCreditCard = new CreditCard();

            objVisaCreditCard.CardType = "Visa";
            objVisaCreditCard.CreditCardNumber = 1234567890123456;
            objVisaCreditCard.ExpirationDateMonth = 12;
            objVisaCreditCard.ExpirationDateYear = 2025;
            objVisaCreditCard.NameOnCard = objPerson.FirstName + " " + objPerson.LastName;
            objVisaCreditCard.CardBallance = 100.00;

            CreditCard objMasterCardCreditCard = new CreditCard();

            objMasterCardCreditCard.CardType = "MasterCard";
            objMasterCardCreditCard.CreditCardNumber = 1234567890123456;
            objMasterCardCreditCard.ExpirationDateMonth = 4;
            objMasterCardCreditCard.ExpirationDateYear = 2023;
            objMasterCardCreditCard.NameOnCard = objPerson.FirstName + " " + objPerson.LastName;
            objMasterCardCreditCard.CardBallance = 100.00;

            CreditCard objDiscoverCreditCard = new CreditCard();

            objDiscoverCreditCard.CardType = "Discover";
            objDiscoverCreditCard.CreditCardNumber = 1234567890123456;
            objDiscoverCreditCard.ExpirationDateMonth = 3;
            objDiscoverCreditCard.ExpirationDateYear = 2027;
            objDiscoverCreditCard.NameOnCard = objPerson.FirstName + " " + objPerson.LastName;
            objDiscoverCreditCard.CardBallance = 100.00;

            objWallet1.CreditCards.Add(objVisaCreditCard);
            objWallet1.CreditCards.Add(objMasterCardCreditCard);
            objWallet1.CreditCards.Add(objDiscoverCreditCard);

            objPerson.Wallets.Add(objWallet1);

            return objPerson;
        }

        public static User SetupCase2UserInformation()
        {
            User objPerson = new User();

            objPerson.FirstName = "John";
            objPerson.LastName = "Goodman";
            objPerson.PhoneNumber = "636-555-1234";
            objPerson.EmailAddress = "john@goodmanent.us";

            Wallet objWallet1 = new Wallet();

            objWallet1.Title = "Main Wallet";
            objWallet1.IsDefault = true;

            Wallet objWallet2 = new Wallet();

            objWallet2.Title = "Secondary Wallet";
            objWallet2.IsDefault = true;

            CreditCard objVisaCreditCard = new CreditCard();

            objVisaCreditCard.CardType = "Visa";
            objVisaCreditCard.CreditCardNumber = 1234567890123456;
            objVisaCreditCard.ExpirationDateMonth = 12;
            objVisaCreditCard.ExpirationDateYear = 2025;
            objVisaCreditCard.NameOnCard = objPerson.FirstName + " " + objPerson.LastName;
            objVisaCreditCard.CardBallance = 100.00;

            CreditCard objDiscoverCreditCard = new CreditCard();

            objDiscoverCreditCard.CardType = "Discover";
            objDiscoverCreditCard.CreditCardNumber = 3246012305696823;
            objDiscoverCreditCard.ExpirationDateMonth = 3;
            objDiscoverCreditCard.ExpirationDateYear = 2027;
            objDiscoverCreditCard.NameOnCard = objPerson.FirstName + " " + objPerson.LastName;
            objDiscoverCreditCard.CardBallance = 100.00;

            objWallet1.CreditCards.Add(objVisaCreditCard);
            objWallet1.CreditCards.Add(objDiscoverCreditCard);

            CreditCard objMasterCardCreditCard = new CreditCard();

            objMasterCardCreditCard.CardType = "MasterCard";
            objMasterCardCreditCard.CreditCardNumber = 1655497930646794;
            objMasterCardCreditCard.ExpirationDateMonth = 4;
            objMasterCardCreditCard.ExpirationDateYear = 2023;
            objMasterCardCreditCard.NameOnCard = objPerson.FirstName + " " + objPerson.LastName;
            objMasterCardCreditCard.CardBallance = 100.00;

            objWallet2.CreditCards.Add(objMasterCardCreditCard);

            objPerson.Wallets.Add(objWallet1);
            objPerson.Wallets.Add(objWallet2);

            return objPerson;
        }

        public static User SetupCase3User1Information()
        {
            User objPerson1 = new User();

            objPerson1.FirstName = "Jim";
            objPerson1.LastName = "Kirk";
            objPerson1.PhoneNumber = "877-555-1234";
            objPerson1.EmailAddress = "jkirk@enterprise.org";

            Wallet objWallet1 = new Wallet();

            objWallet1.Title = "Main Wallet";
            objWallet1.IsDefault = true;

            CreditCard objVisaCreditCard1 = new CreditCard();

            objVisaCreditCard1.CardType = "Visa";
            objVisaCreditCard1.CreditCardNumber = 5685099059257198;
            objVisaCreditCard1.ExpirationDateMonth = 12;
            objVisaCreditCard1.ExpirationDateYear = 2025;
            objVisaCreditCard1.NameOnCard = objPerson1.FirstName + " " + objPerson1.LastName;
            objVisaCreditCard1.CardBallance = 100.00;

            CreditCard objMasterCardCreditCard1 = new CreditCard();

            objMasterCardCreditCard1.CardType = "MasterCard";
            objMasterCardCreditCard1.CreditCardNumber = 3534008947733405;
            objMasterCardCreditCard1.ExpirationDateMonth = 4;
            objMasterCardCreditCard1.ExpirationDateYear = 2023;
            objMasterCardCreditCard1.NameOnCard = objPerson1.FirstName + " " + objPerson1.LastName;
            objMasterCardCreditCard1.CardBallance = 100.00;

            objWallet1.CreditCards.Add(objVisaCreditCard1);
            objWallet1.CreditCards.Add(objMasterCardCreditCard1);

            objPerson1.Wallets.Add(objWallet1);

            return objPerson1;
        }

        public static User SetupCase3User2Information()
        {
            User objPerson2 = new User();

            objPerson2.FirstName = "Jean";
            objPerson2.LastName = "Luc";
            objPerson2.PhoneNumber = "999-555-1234";
            objPerson2.EmailAddress = "jluc@enterprise.org";

            Wallet objWallet2 = new Wallet();

            objWallet2.Title = "Main Wallet";
            objWallet2.IsDefault = true;

            CreditCard objVisaCreditCard2 = new CreditCard();

            objVisaCreditCard2.CardType = "Visa";
            objVisaCreditCard2.CreditCardNumber = 1331868519581444;
            objVisaCreditCard2.ExpirationDateMonth = 12;
            objVisaCreditCard2.ExpirationDateYear = 2025;
            objVisaCreditCard2.NameOnCard = objPerson2.FirstName + " " + objPerson2.LastName;
            objVisaCreditCard2.CardBallance = 100.00;

            CreditCard objMasterCardCreditCard2 = new CreditCard();

            objMasterCardCreditCard2.CardType = "MasterCard";
            objMasterCardCreditCard2.CreditCardNumber = 7987793811143792;
            objMasterCardCreditCard2.ExpirationDateMonth = 4;
            objMasterCardCreditCard2.ExpirationDateYear = 2023;
            objMasterCardCreditCard2.NameOnCard = objPerson2.FirstName + " " + objPerson2.LastName;
            objMasterCardCreditCard2.CardBallance = 100.00;

            objWallet2.CreditCards.Add(objVisaCreditCard2);
            objWallet2.CreditCards.Add(objMasterCardCreditCard2);

            objPerson2.Wallets.Add(objWallet2);

            return objPerson2;
        }
    }
}
