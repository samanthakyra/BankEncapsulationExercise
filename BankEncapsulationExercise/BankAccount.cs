using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BankEncapsulationExercise
{
    public class BankAccount
    {
        private double _balance;
        public void Deposit(double amount)

        {
            Console.WriteLine($"There is a deposit of {amount, 0:c}. It will be processed into your account shortly");
            _balance = amount;
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}

