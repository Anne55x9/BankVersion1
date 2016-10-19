using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{


    public class BankAccount
    {
        private string name;
        private double balance;

        private double deposit;
        private double withdrawel;

        public BankAccount()
        {
            name = "Anne Sofie";
            balance = 543.7;
        }

        public void AddDeposit(double deposit)
        {
           balance  = deposit + balance;
        }

        public void AddWithdrawel(double withdrawel)
        {
            balance = balance - withdrawel;
        }

        public string Getname()
        {
            return name;
        }

        public double GetBalance()
        {
            return balance;
        }

       
 
    }
}
