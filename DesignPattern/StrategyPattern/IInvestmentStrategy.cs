using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Strategy Interface
    public interface IInvestmentStrategy
    {
        //algorithmInterface()-Methode aus dem UML-Klassendiagramm
        void Invest(double investMoney);
    }
}
