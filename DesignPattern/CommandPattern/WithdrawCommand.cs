using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    //Concrete Command 1 
    public class WithdrawCommand : IBankTransactionCommand
    {
        private BankAccount bankAccount;
        private double amount;
        private bool transactionSucceeded; 

        public WithdrawCommand(BankAccount bankAccount, double amount)
        {
            this.bankAccount = bankAccount;
            this.amount = amount;
        }

        public void Execute()
        {
            transactionSucceeded = bankAccount.Withdraw(amount);
        }
        public void Undo()
        {
            if (transactionSucceeded)
            {
                bankAccount.Balance += amount;
                Console.WriteLine($"Auszahlung wurde rückgängig gemacht. Kontostand {bankAccount.Balance}");
            }
            else
            {
                Console.WriteLine("Konnte Undo-Operation nicht durchführen.");
            }
            
        }
    }
}
