using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    //abstraktes Produkt
    public abstract class Transport
    {
        public string Customer {  get; set; }
        public string Destination { get; set; }

        public void CollectProductFromCustomer()
        {
            Console.WriteLine("Die Produkte werden abgeholt.");
        }

        public abstract void TransportProducts();
    }
}
