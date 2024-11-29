using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    // Concrete Class 2
    public class ManagerWorkday : WorkdayPlanner
    {
        public override void GoToWork()
        {
            Console.WriteLine("Manager fährt ins Büro");
        }

        public override void Work()
        {
            Console.WriteLine("Manager managed seine Abteilung");
        }
    }
}
