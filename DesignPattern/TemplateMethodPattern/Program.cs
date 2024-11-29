namespace TemplateMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sorgt dafür, dass Teilschritte eines Algorithmus variabel gehalten werden können 

            // Beispiel: WorkdayPlanner, für alle möglichen Berufe.
            // Hier gibt es Teilschritte, die für alle Menschen gleich sind, aber auch viele unterschiedliche Teilschritte

            ManagerWorkday mw = new ManagerWorkday();
            mw.CreateWorkday();

            Console.WriteLine();
            Console.WriteLine();

            PoliceOfficerWorkday pw = new PoliceOfficerWorkday();
            pw.CreateWorkday();
        }
    }
}
