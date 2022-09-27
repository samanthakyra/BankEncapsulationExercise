using System;

namespace BankEncapsulationExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount money = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");
            double amountToDeposit = double.Parse(Console.ReadLine());

            money.Deposit(amountToDeposit);
            double userBalance = money.GetBalance();

            Console.WriteLine($"Your current balance is: {userBalance,0:c}");
        }
    }
}

