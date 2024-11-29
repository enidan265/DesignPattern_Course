using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // Concrete Command 2
    public class DepositCommand : IBankTransactionCommand
    {
        private BankAccount bankAccount;
        private double amount;

        public DepositCommand(BankAccount bankAccount, double amount)
        {
            this.bankAccount = bankAccount;
            this.amount = amount;
        }

        public void Execute()
        {
            bankAccount.Deposit(amount);
        }

        public void Undo()
        {
            bankAccount.Balance -= amount;
            Console.WriteLine($"Einzahlung wurde rückgängig gemacht. Kontostand: {bankAccount.Balance}");
        }
    }
}
