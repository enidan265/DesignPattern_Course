using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    // Concrete State 1
    public class CarState : State
    {
        private AmphibiousVehicle amphibiousVehicle;

        public CarState(AmphibiousVehicle amphibiousVehicle)
        {
            this.amphibiousVehicle = amphibiousVehicle;
        }

        public override void Accelerate()
        {
            Console.WriteLine("Beschleunige mit dem Motor und den 4 Rädern.");
        }

        public override void SlowDown()
        {
            Console.WriteLine("Verwende die Bremse um langsamer zu werden.");
        }
    }
}
