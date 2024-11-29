using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    //Concrete Product 2 
    public class RoadTransport : Transport
    {
        public override void TransportProducts()
        {
            Console.WriteLine("Die Produkte werden über den Straßenweg transportiert.");
        }
    }
}
