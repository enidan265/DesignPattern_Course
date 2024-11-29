using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AbstractFactoryPattern
{
    //abstract Product 1
    public abstract class Engine
    {
        public double EngineSpeed { get; set; }
        public abstract void RevCounter();
    }
}
