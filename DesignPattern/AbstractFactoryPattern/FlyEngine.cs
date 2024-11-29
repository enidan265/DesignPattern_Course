using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    //concrete Product 1.1
    public class FlyEngine : Engine
    {
        public FlyEngine()
        {
            Console.WriteLine("Der FlyEngine wurde erstellt.");
        }

        public override void RevCounter()
        {
            Console.WriteLine("Die Drehzahl beträgt 300 Umdrehungen/min");
        }
    }
}
