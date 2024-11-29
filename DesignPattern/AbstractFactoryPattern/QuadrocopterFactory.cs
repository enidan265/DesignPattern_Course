using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    //abstract Factory
    public abstract class QuadrocopterFactory
    {
        public abstract Engine CreateEngine();
        public abstract Regulator CreateRegulator();
    }
}
