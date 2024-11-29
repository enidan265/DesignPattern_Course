using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    // Concrete State 2
    public class BoatState : State
    {
        private AmphibiousVehicle amphibiousVehicle;

        public BoatState(AmphibiousVehicle amphibiousVehicle)
        {
            this.amphibiousVehicle = amphibiousVehicle;
        }

        public override void Accelerate()
        {
            Console.WriteLine("Beschleunige mithilfe der Schiffschraube");
        }

        public override void SlowDown()
        {
            Console.WriteLine("Bremse indem die Schiffsschraube in die andere Richtung dreht.");
        }
    }
}
