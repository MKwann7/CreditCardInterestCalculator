using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CreditCardInterestCalculator.Entities;

namespace CreditCardInterestCalculator.TestingClasses
{
    [TestFixture]
    public class Case3
    {
        [Test]
        public void TestTotalUser1Interest()
        {
            User objPerson1 = CaseData.SetupCase3User1Information();

            double dblTotalInterestFromUserCreditCards = objPerson1.GetTotalInterestFromAllUserCreditCards();

            Assert.That(dblTotalInterestFromUserCreditCards, Is.EqualTo(15));
        }

        [Test]
        public void TestUser1Wallet1Interest()
        {
            User objPerson1 = CaseData.SetupCase3User1Information();

            List<double> lstTotalWalletInterestFromUserCreditCards = objPerson1.GetTotalInterestFromUserCreditCardsByWallet();

            Assert.That(lstTotalWalletInterestFromUserCreditCards[0], Is.EqualTo(15));
        }

        [Test]
        public void TestTotalUser2Interest()
        {
            User objPerson2 = CaseData.SetupCase3User2Information();

            double dblTotalInterestFromUserCreditCards = objPerson2.GetTotalInterestFromAllUserCreditCards();

            Assert.That(dblTotalInterestFromUserCreditCards, Is.EqualTo(15));
        }

        [Test]
        public void TestUser2Wallet1Interest()
        {

            User objPerson2 = CaseData.SetupCase3User2Information();

            List<double> lstTotalWalletInterestFromUserCreditCards = objPerson2.GetTotalInterestFromUserCreditCardsByWallet();

            Assert.That(lstTotalWalletInterestFromUserCreditCards[0], Is.EqualTo(15));
        }
    }
}
