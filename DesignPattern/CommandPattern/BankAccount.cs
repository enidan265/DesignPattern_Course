using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // Receiver
    public class BankAccount
    {
        public double Balance { get; set; } = 0;
        public double OverdraftLimit { get; set; } = -1000; 

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"Es wurden {amount} Euro auf das Konto eingezahlt. \n " +
                $"Der neue Kontostand beträgt {Balance} Euro.");
        }

        public bool Withdraw(double amount)
        {
            if(Balance - amount >= OverdraftLimit)
            {
                Balance -= amount;
                Console.WriteLine($"Es wurden {amount} Euro vom Konto abgehoben. \n " +
                    $"Der neue Kontostand beträgt {Balance} Euro.");
                return true;
            }
            else
            {
                Console.WriteLine("Leider ist nicht genug Geld auf dem Konto.");
                return false;
            }

        }

        public override string ToString()
        {
            return $"Kontostand: {Balance}, Überzugslimit: {OverdraftLimit}";
        }

    }
}
