using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Aufgabe1
{
    public class HammerShieldItemDrop : ItemDrop
    {
        protected override Item ItemFactory(int itemId)
        {
            Item item = null; 

            if(itemId == 0)
            {
                item = new Hammer();
            }
            else if(itemId == 1)
            {
                item = new Shield();
            }
            else
            {
                Console.WriteLine("Ungültige ItemId");
            }

            return item;
        }
    }
}
