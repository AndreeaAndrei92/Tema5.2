using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    class Mortgage : Account, IAccount
    {
        public Mortgage(Customer customer, double montlyInterest)
            : base(customer, montlyInterest)
        {

        }
        public Mortgage(Customer customer, double balance, double monthlyInterest)
            : base(customer, balance, monthlyInterest)
        {

        }

        public override double CalcInterest(int months)
        {
            if (months >= 0)
            {
                if (this.Customer.GetType().Name == "Individual")
                {
                    if (months <= 6)
                    {
                        return 0;
                    }
                    else
                    {
                        return (months - 6) * this.MonthlyInterestRate;
                    }
                }
                else
                {
                    if (months <= 12)
                    {
                        return 12 * this.MonthlyInterestRate / 2;
                    }
                    else
                    {
                        return 12 * this.MonthlyInterestRate / 2 + (months - 12) * this.MonthlyInterestRate;
                    }
                }
            }
            else
            {
                throw new InvalidOperationException("monthes cannot be negative");
            }
        }
    }
}

