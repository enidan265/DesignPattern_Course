using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    //concrete Product 2.1
    public class FlyRegulator : Regulator
    {
        public FlyRegulator()
        {
            Console.WriteLine("Der FlyRegulator wurde erstellt");
        }
        public override void IncreaseVoltage()
        {
            Console.WriteLine("Die Spannung wurde um 10 Volt erhöht");
        }
    }
}
