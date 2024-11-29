using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Concrete Component 2
    public class MacBookPro : IMacBook
    {
        public string GetDescription()
        {
            return "MacBook Pro \n Standard Ausstattung";
        }

        public double GetPrice()
        {
            return 1199.99;
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Die Lautstärke wurde erhöht.");
        }
    }
}
