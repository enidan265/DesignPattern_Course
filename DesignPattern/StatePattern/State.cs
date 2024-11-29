using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    // abstract State class
    public abstract class State
    {
        //Methoden, die jeder Zustand selbst implementieren muss
        public abstract void Accelerate();
        public abstract void SlowDown();
    }
}
