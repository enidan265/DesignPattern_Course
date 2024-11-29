using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    //Component
    public interface IMacBook
    {
        string GetDescription();
        double GetPrice();
        void IncreaseVolume();
    }
}
