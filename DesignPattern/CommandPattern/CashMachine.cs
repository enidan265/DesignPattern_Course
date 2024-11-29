using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    // Invoker
    public class CashMachine
    {
        public void ExecuteBankTransaction(IBankTransactionCommand command)
        {
            command.Execute();
            // Datenbank schreiben -> Logdatei erstellen 
        }

        public void UndoBankTransaction(IBankTransactionCommand command)
        {
            command.Undo();
        }
    }
}
