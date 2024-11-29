using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    // concrete Decorator 2
    public class MacBookI5Processor : MacBookAddon
    {
        public MacBookI5Processor(IMacBook macBook) : base(macBook) { }
        
        public override string GetDescription()
        {
            return macBook.GetDescription() + " I5Processor";
        }

        public override double GetPrice()
        {
            return macBook.GetPrice() + 500.00;
        }

        public override void IncreaseVolume()
        {
            macBook.IncreaseVolume(); 
        }
    }
}
