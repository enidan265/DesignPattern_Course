using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AbstractFactoryPattern
{
    //abstract Product 2
    public abstract class Regulator
    {
        public double CurrentVoltage { get; set; }
        public double CurrentCurrent {  get; set; }

        public abstract void IncreaseVoltage();
    }
}
