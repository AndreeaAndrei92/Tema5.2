using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public interface IAccount
    {
        Customer customer { get; }
        double Balance { get; }
        double MonthlyInterestRate { get; }
        void DepositMoney(double amountOfMoney);
        double CalcInterest(int months);

    }
}

