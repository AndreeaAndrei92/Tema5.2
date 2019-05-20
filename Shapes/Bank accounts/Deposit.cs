using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    class Deposit : Account, IAccount, IWithdrawable
    {
        public Deposit(Customer customer, double monthlyInterest)
            : base(customer, monthlyInterest)
        {
        }

        public Deposit(Customer customer, double balance, double monthlyInterest)
            : base(customer, balance, monthlyInterest)
        {
        }

        public override double CalcInterest(int months)
        {
            if (this.Balance <= 100)
            {
                return 0;
            }
            else
            {
                return this.MonthlyInterestRate * months;
            }
        }

        public void WithdrawMoney(double amountOfMoney)
        {
            if (this.Balance <= amountOfMoney)
            {
                throw new InvalidOperationException("Less money in the balance than the reqeusted ammount for withdrawel");
            }
            else
            {
                this.Balance -= amountOfMoney;
            }
        }

    }
}

