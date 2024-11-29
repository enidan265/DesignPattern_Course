using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    //Subsystem 1
    public class AirportSystem
    {
        public void CheckLuggage()
        {
            Console.WriteLine("Das Gepäck wurde am Flughafen eingecheckt.");
        }
        public void TransportLuggageToAirplane()
        {
            Console.WriteLine("Das Gepäck zum Flugzeug");
        }
    }
}
