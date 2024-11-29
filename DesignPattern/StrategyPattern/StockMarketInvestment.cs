using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Concrete Strategy 3
    public class StockMarketInvestment : IInvestmentStrategy
    {
        public void Invest(double investMoney)
        {
            //Algorithmus wird hier hinterlegt
            Console.WriteLine($"Du hast {investMoney} in Aktien investiert.");
        }
    }
}
