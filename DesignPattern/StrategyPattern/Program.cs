namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Definition einer Familie von Algorithmen, die einzeln gekapselt und austauschbar sind
            // --> während der Laufzeit kann der gewünschte Algorithmus ausgeführt werden 

            //Beispiel: Investment soll gemacht werden, dieses kann bei der Bank auf 3 unterschiedliche Weisen gemacht werden 
            //              Gold; Krypto; Aktien
            //          Hinter jeden Investment-Art verbirgt sich ein Algorithmus, wie hier maximal gewinnbringend investiert werden kann 

            Investment inv = new Investment(300.00);
            inv.SetInvestmentStrategy(new GoldInvestment());
            inv.TalkToBankEmployee();
            inv.MakeInvestment();
        }
    }
}
