using System;
using System.Collections.Generic;
using System.Text;

namespace bankaccount
{
    public class bankAccountMacie
    {
        private double _balance = 0;
        
        public void Deposit(double amount)
        {
            Console.WriteLine($"Simulating a deposit of {amount,0:c} to your account!");
            _balance = amount;
        }

        public double GetBalance()
        {
            return _balance;
        }
    }
}
