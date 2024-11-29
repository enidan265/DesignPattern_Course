namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zur Laufzeit Klassen um Funktionalitäten erweitern
            // Beispiel: MacBooks, davon gibt es zwei Varianten: 
            //              MacBookPro & MacBookAir
            // für diese können jeweils noch zusätzliche Ausstattung gewählt werden (z.B. Touchbar)

            MacBookPro pc1 = new MacBookPro();
            MacBookTouchbar macBookWithTouchbar = new MacBookTouchbar(pc1);

            MacBookI5Processor macBookTouchI5 = new MacBookI5Processor(macBookWithTouchbar);

            Console.WriteLine(macBookTouchI5.GetDescription());
            Console.WriteLine(macBookTouchI5.GetPrice());
            macBookTouchI5.IncreaseVolume();


        }
    }
}
