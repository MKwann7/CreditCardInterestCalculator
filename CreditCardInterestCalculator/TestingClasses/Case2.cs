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
    public class Case2
    {
        [Test]
        public void TestTotalUserInterest()
        {
            User objPerson = CaseData.SetupCase2UserInformation();

            double dblTotalInterestFromUserCreditCards = objPerson.GetTotalInterestFromAllUserCreditCards();

            Assert.That(dblTotalInterestFromUserCreditCards, Is.EqualTo(16));
        }

        [Test]
        public void TestUserWallet1Interest()
        {
            User objPerson = CaseData.SetupCase2UserInformation();

            List<double> lstTotalWalletInterestFromUserCreditCards = objPerson.GetTotalInterestFromUserCreditCardsByWallet();

            Assert.That(lstTotalWalletInterestFromUserCreditCards[0], Is.EqualTo(11));
        }

        [Test]
        public void TestUserWallet2Interest()
        {
            User objPerson = CaseData.SetupCase2UserInformation();

            List<double> lstTotalWalletInterestFromUserCreditCards = objPerson.GetTotalInterestFromUserCreditCardsByWallet();

            Assert.That(lstTotalWalletInterestFromUserCreditCards[1], Is.EqualTo(5));
        }
    }
}
