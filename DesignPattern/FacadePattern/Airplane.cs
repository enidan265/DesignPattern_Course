using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    //Subsystem 2
    public class Airplane
    {
        public void PutLuggageIn()
        {
            Console.WriteLine("Gepäck ins Flugzeug eingeladen");
        }
        public void PutLuggageOut()
        {
            Console.WriteLine("Gepäck aus Flugzeug ausgeladen");
        }
    }
}
