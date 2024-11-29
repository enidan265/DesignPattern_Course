using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    // abstract Class
    public abstract class WorkdayPlanner
    {
        // templateMethod() aus UML-Klassendiagramm
        // enthält alle Teilschritte
        public void CreateWorkday()
        {
            WakeUp();
            TakeShower();
            Breakfast();
            GoToWork();
            Work();
            Sleep();
        }
        // spezifische Methoden als abstracte Methoden anlegen
        public abstract void GoToWork();
        public abstract void Work();

        // Methoden implementieren, die für alle gleich sind
        public void WakeUp()
        {
            Console.WriteLine("Aufwachen...");
        }
        public void TakeShower()
        {
            Console.WriteLine("Duschen...");
        }
        public void Breakfast()
        {
            Console.WriteLine("Frühstücken...");
        }
        public void Sleep()
        {
            Console.WriteLine("Schlafen...");
        }
    }
}
