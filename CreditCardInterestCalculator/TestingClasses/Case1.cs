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
    public class Case1
    {
        [Test]
        public void TestCreditCardInterestValue()
        {
            User objPerson = CaseData.SetupCase1UserInformation();

            double dblTotalInterestFromUserCreditCards = objPerson.GetTotalInterestFromAllUserCreditCards();

            Assert.That(dblTotalInterestFromUserCreditCards, Is.EqualTo(16));
        }
    }
}
