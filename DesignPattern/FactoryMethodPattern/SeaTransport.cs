using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    //Concrete Product 3 
    public class SeaTransport : Transport
    {
        public override void TransportProducts()
        {
            Console.WriteLine("Die Produkte werden über den Seeweg transportiert.");
        }
    }
}
