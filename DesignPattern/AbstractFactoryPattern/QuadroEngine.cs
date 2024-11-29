using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    //concrete Product 1.2
    public class QuadroEngine : Engine
    {
        public QuadroEngine()
        {
            Console.WriteLine("Der QuadroEngine wurde erstellt.");
        }

        public override void RevCounter()
        {
            Console.WriteLine("Die Drehzahl beträgt 300 Umdrehungen/min");
        }
    }
}
