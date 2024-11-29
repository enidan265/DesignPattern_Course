using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Aufgabe1
{
    public abstract class ItemDrop
    {
        protected abstract Item ItemFactory(int itemId);

        public Item DropRandomItem()
        {
            int itemId = RandomItemId();
            
            Item item = ItemFactory(itemId);

            item.UseItem();

            return item;
        }

        protected int RandomItemId()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
    }
}
