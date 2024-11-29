using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //nicht kompatible Klasse
    public class Wizard
    {
        public void AttackPlayer()
        {
            Console.WriteLine("Der Zauberer greift an.");
        }
        public void Rest()
        {
            Console.WriteLine("Der Zauberer ruht sich aus.");
        }
        public void Communicate()
        {
            Console.WriteLine("Der Zauberer sagt hallo.");
        }
    }
}
