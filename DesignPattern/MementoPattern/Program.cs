namespace MementoPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Speichern des inneren Zustands eines Objekts, um Objekt zu einem späteren Zustand wieder in diesen Zustand zurückversetzen zu können 
            // Zudem ist durch das Pattern sichergestellt, dass die Kapselung nicht verletzt wird

            // Beispiel: Fitnessplan, bei dem man das aktuelle Fitnessprogramm speichern und später wieder aufrufen kann. 

            Caretakter caretakter = new Caretakter();
            
            FitnessPlan plan = new FitnessPlan("Krafttraining");
            Console.WriteLine(plan);
            caretakter.SaveState(plan);

            plan.ChangeTypeOfTraining("Joggen");
            Console.WriteLine(plan);
            caretakter.SaveState(plan);

            plan.ChangeTypeOfTraining("Gemischtes Training");
            Console.WriteLine(plan);
            caretakter.SaveState(plan);

            caretakter.RestoreState(plan, 0);
            Console.WriteLine(plan);





        }
    }
}
