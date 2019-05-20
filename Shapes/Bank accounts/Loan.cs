using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    class Loan : Account, IAccount
    {
        private readonly int monthsWithoutInterestForIndividuals = 3;
        private readonly int monthsWithoutInterestForCompanies = 2;
        public Loan(Customer customer, double monthlyInterest)
            : base(customer, monthlyInterest)
        {

        }
        public Loan(Customer customer, double balance, double montlyInterest)
            : base(customer, balance, montlyInterest)
        {

        }

        public override double CalcInterest(int months)
        {
            if (this.Customer.GetType().Name == "Individual")
            {
                if (months > monthsWithoutInterestForIndividuals)
                {
                    return (months - monthsWithoutInterestForIndividuals) * this.MonthlyInterestRate;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (months > monthsWithoutInterestForCompanies)
                {
                    return (months - monthsWithoutInterestForCompanies) * this.MonthlyInterestRate;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}

