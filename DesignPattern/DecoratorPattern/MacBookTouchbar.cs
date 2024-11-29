using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //concrete Decorator 1
    public class MacBookTouchbar : MacBookAddon
    {
        public MacBookTouchbar(IMacBook macBook) : base(macBook) { }

        public override string GetDescription()
        {
            return macBook.GetDescription() + " Touchbar";
        }

        public override double GetPrice()
        {
            return macBook.GetPrice() + 400.00;
        }

        public override void IncreaseVolume()
        {
            Console.WriteLine("Die Lautstärke wurde mit Hilfe der Touchbar erhöht.");
        }
    }
}
