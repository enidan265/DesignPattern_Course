using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod_Aufgabe1
{
    public class Shield : Item
    {
        public int DefenseValue { get; set; }

        public Shield()
        {
            Id = 1;
            Name = "Shield";
            DefenseValue = 3;
        }
        
        public override void UseItem()
        {
            Console.WriteLine("Das Schild wird verwendet.");
        }
    }
}
