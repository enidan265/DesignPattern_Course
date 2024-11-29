using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    //concrete Creator
    public class SeaRoadFlightLogistics : Logistics
    {
        protected override Transport TransportFactory(string transportType)
        {
            Transport transport = null;
            if(transportType == "road")
            {
                transport = new RoadTransport();
            }
            else if(transportType == "air")
            {
                transport = new FlightTransport();
            }
            else if(transportType == "sea")
            {
                transport = new SeaTransport();
            }
            else
            {
                Console.WriteLine("Ungültiger Transporttyp");
            }

            return transport;
        }
    }
}
