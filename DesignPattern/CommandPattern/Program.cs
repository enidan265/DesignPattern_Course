namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Befehle werden in extra Befehlsobjekte gekapselt, um: 
            //      - Anfragen zu parametrisieren
            //      - Operationen in Schlange einreihen
            //      - Logbuch führen
            //      - Operationen rückgängig machen 

            // Beispiel: Bankautomat, an welchem man Geld einzahlen und abheben kann 

            BankAccount nadineBA = new BankAccount();
            Console.WriteLine($"Konto wurde eröffnet: {nadineBA}");

            CashMachine cashMachineSC = new CashMachine();

            IBankTransactionCommand command1 = new DepositCommand(nadineBA, 2000);
            IBankTransactionCommand command2 = new WithdrawCommand(nadineBA, 5000);
            IBankTransactionCommand command3 = new DepositCommand(nadineBA, 1000);

            
            // CashMachine muss nicht wissen um welche Commands es sich handelt 
            cashMachineSC.ExecuteBankTransaction(command1);
            cashMachineSC.UndoBankTransaction(command1);
            cashMachineSC.ExecuteBankTransaction(command2);
            cashMachineSC.UndoBankTransaction(command2); 
            cashMachineSC.ExecuteBankTransaction(command3);


        }
    }
}
