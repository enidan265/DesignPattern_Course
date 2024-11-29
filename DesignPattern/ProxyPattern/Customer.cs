using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public bool BonusCard { get; set; }

        public Customer(string name, string address, bool bonusCard)
        {
            Name = name;
            Address = address;
            BonusCard = bonusCard;
        }
    }
}
