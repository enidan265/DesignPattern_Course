using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    //Concrete Product 1 
    public class FlightTransport : Transport
    {
        public override void TransportProducts()
        {
            Console.WriteLine("Die Produkte werden über den Luftweg transportiert.");
        }
    }
}
