using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public abstract class Account : IAccount
    {
        private readonly double initialBalance = 5;
        private Customer customer;
        private double balance;
        private double monthlyInterest;

        public Account(Customer customer, double monthlyInterest)
        {
            this.Customer = customer;
            this.MonthlyInterest = monthlyInterest;
            this.Balance = initialBalance;
        }

        public Account(Customer customer, double balance, double monthlyInterest)
            : this(customer, monthlyInterest)
        {
            this.balance = balance;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                this.customer = value;
            }
        }

        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public double MonthlyInterestRate
        {
            get
            {
                return this.monthlyInterest;
            }
            set
            {
                this.monthlyInterest = value;
            }
        }

        public void DepositMoney(double amountOfMoney)
        {
            this.balance += amountOfMoney;
        }
        public abstract double CalcInterest(int months);
    }

}

