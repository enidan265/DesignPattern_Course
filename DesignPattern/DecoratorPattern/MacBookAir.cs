using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Concrete Component 1
    public class MacBookAir : IMacBook
    {
        public string GetDescription()
        {
            return "MacBook Air \n Standard Ausstattung";
        }

        public double GetPrice()
        {
            return 799.99;
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Die Lautstärke wurde erhöht.");
        }
    }
}
