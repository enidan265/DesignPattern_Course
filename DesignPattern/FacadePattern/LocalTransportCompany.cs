using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    //Subsystem 3
    public class LocalTransportCompany
    {
        public void PutLuggageIntoTruck()
        {
            Console.WriteLine("Gepäck in Truck");
        }
        public void TransportLuggageToHotel()
        {
            Console.WriteLine("Gepäck ins Hotel");
        }
    }

}
