namespace ChainOfResponsibilityPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Objekt, das eine Anfrage startet wird vom Objekt, welches die Anfrage bearbeitet, entkoppelt. 
            // Anfrage wird durch eine Kette von Bearbeitern hindurchgereicht, bis der zuständige Bearbeiter erreicht wird. 

            // Beispiel: Einfacher Taschenrechner, wobei je Bearbeiter eine Grundrechenart 

            // Verkettung durchführen: 
            AddOperation chain1 = new AddOperation();
            SubstractOperation chain2 = new SubstractOperation();
            MultiplyOperation chain3 = new MultiplyOperation();
            DivideOperation chain4 = new DivideOperation();

            chain1.SetNextChainLink(chain2);
            chain2.SetNextChainLink(chain3);
            chain3.SetNextChainLink(chain4);

            // Anfrage stellen: 
            Numbers request1 = new Numbers(10, 5, "+");
            Numbers request2 = new Numbers(10, 5, "*");

            chain1.Calculate(request1);
            chain1.Calculate(request2); //wird an chain1 übergeben, aber bis chain4 durchgereicht
        }
    }
}
