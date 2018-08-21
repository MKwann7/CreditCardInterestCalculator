﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardInterestCalculator.Interfaces
{
    public interface IUser
    {
        double GetTotalInterestFromAllUserCreditCards();

        List<double> GetTotalInterestFromUserCreditCardsByWallet();
    }
}
