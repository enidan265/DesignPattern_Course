using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //mein Interface
    public interface IEnemyObject
    {
        void Attack();
        void Sleep();
        void SayHello();

    }
}
