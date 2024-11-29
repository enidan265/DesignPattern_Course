using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    //abstract Creator
    public abstract class Logistics
    {
        //factoryMethod()
        protected abstract Transport TransportFactory(string transportType);

        //anOperation-Method(s)
        public Transport ManageTransportForCustomer(string transportType)
        {
            Transport transport = TransportFactory(transportType);

            transport.CollectProductFromCustomer();
            transport.TransportProducts();

            return transport;
        }

    }
}
