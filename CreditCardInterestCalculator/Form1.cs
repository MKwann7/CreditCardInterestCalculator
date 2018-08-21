using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreditCardInterestCalculator.Entities;
using CreditCardInterestCalculator.TestingClasses;

namespace CreditCardInterestCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User objCase1Person = CaseData.SetupCase1UserInformation();

            PrintUserDataToTextBox(objCase1Person);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            User objCase2Person = CaseData.SetupCase2UserInformation();

            PrintUserDataToTextBox(objCase2Person);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            User objCase3Person1 = CaseData.SetupCase3User1Information();

            PrintUserDataToTextBox(objCase3Person1);

            User objCase3Person2 = CaseData.SetupCase3User2Information();

            PrintUserDataToTextBox(objCase3Person2);
        }

        private void PrintUserDataToTextBox(User objPerson)
        {
            if (objPerson == null)
            {
                return;
            }

            textBox1.AppendText("Name: " + objPerson.FirstName + " " + objPerson.LastName + "\n");
            textBox1.AppendText("Phone: " + objPerson.PhoneNumber + "\n");
            textBox1.AppendText("Email: " + objPerson.EmailAddress + "\n\n");


            double dblTotalInterestFromUserCreditCards = objPerson.GetTotalInterestFromAllUserCreditCards();

            if (objPerson.Wallets.Count() == 0)
            {
                return;
            }

            foreach( Wallet curWallet in objPerson.Wallets)
            {
                textBox1.AppendText("Wallet: " + curWallet.Title + "\n");
                textBox1.AppendText("Default: " + curWallet.IsDefault.ToString() + "\n" + System.Environment.NewLine + System.Environment.NewLine);

                RenderAllCardsInWallet(curWallet);
            }

            textBox1.AppendText("Total User Interest from Credit Cards: $" + dblTotalInterestFromUserCreditCards.ToString() + "\n" + System.Environment.NewLine + System.Environment.NewLine);
        }

        private void RenderAllCardsInWallet(Wallet objWallet)
        {
            if (objWallet == null)
            {
                return;
            }

            if (objWallet.CreditCards.Count() == 0)
            {
                return;
            }

            foreach (CreditCard curCreditCard in objWallet.CreditCards)
            {
                textBox1.AppendText("Card Number: XXX" + curCreditCard.CreditCardNumber.ToString().Substring(12) + "\n");
                textBox1.AppendText("Card Type: " + curCreditCard.CardType + "\n");
                textBox1.AppendText("Card Expiration: " + curCreditCard.ExpirationDateMonth.ToString() + "/" + curCreditCard.ExpirationDateYear.ToString() + "\n");
                textBox1.AppendText("Card Ballance: $" + curCreditCard.CardBallance.ToString() + "\n");
                textBox1.AppendText("Card Interest: $" + curCreditCard.CardInterest.ToString() + "\n" + System.Environment.NewLine + System.Environment.NewLine);
            }

            double dblTotalWalletInterestFromUserCreditCards = objWallet.GetTotalInterestFromAllCreditCards();

            textBox1.AppendText("Total Wallet Interest [" + objWallet.Title + "] from Credit Cards: $" + dblTotalWalletInterestFromUserCreditCards.ToString() + "\n" + System.Environment.NewLine + System.Environment.NewLine);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
