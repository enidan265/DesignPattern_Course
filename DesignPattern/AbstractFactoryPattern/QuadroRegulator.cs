using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    //concrete Product 2.2
    public class QuadroRegulator : Regulator
    {
        public QuadroRegulator()
        {
            Console.WriteLine("Der QuadroRegulator wurde erstellt");
        }
        public override void IncreaseVoltage()
        {
            Console.WriteLine("Die Spannung wurde um 30 Volt erhöht");
        }
    }
}
