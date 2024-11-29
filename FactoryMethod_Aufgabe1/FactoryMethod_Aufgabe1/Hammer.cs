using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Aufgabe1
{
    public class Hammer : Item
    {
        public int AttackValue { get; set; }

        public Hammer()
        {
            Id = 0;
            Name = "Hammer";
            AttackValue = 5; 
        }
        public override void UseItem()
        {
            Console.WriteLine("Der Hammer wird verwendet.");
        }
    }
}
