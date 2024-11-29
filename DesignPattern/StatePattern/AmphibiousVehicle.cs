using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    // Context class
    public class AmphibiousVehicle
    {
        private CarState car;
        private BoatState boat;

        private State currentState; 

        public AmphibiousVehicle()
        {
            car = new CarState(this);
            boat = new BoatState(this);
            currentState = car; 
        }

        public void PrepareForWater()
        {
            currentState = boat;
            Console.WriteLine("Das Fahrzeug wurde für das Wasser vorbereitet.");
        }

        public void PrepareForLand()
        {
            currentState = car;
            Console.WriteLine("Das Fahrzeug wurde für das Land vorbereitet");
        }

        // hier werden je nach Status die jeweiligen Methoden aufgerufen 
        public void Accelarate()
        {
            currentState.Accelerate();
        }

        public void SlowDown()
        {
            currentState.SlowDown();
        }

    }
}
