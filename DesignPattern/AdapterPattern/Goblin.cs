using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //kompatible Klasse 
    public class Goblin : IEnemyObject
    {
        public void Attack()
        {
            Console.WriteLine("Der Goblin greift an.");
        }

        public void SayHello()
        {
            Console.WriteLine("Der Goblin begrüßt dich.");
        }

        public void Sleep()
        {
            Console.WriteLine("Der Goblin legt sich schlafen.");
        }
    }
}
