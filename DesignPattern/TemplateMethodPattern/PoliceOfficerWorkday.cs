using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    // Concrete Class 1
    public class PoliceOfficerWorkday : WorkdayPlanner
    {
        public override void GoToWork()
        {
            Console.WriteLine("Polizist fährt zur Wache");
        }

        public override void Work()
        {
            Console.WriteLine("Polizist beschützt die Bürger");
        }
    }
}
