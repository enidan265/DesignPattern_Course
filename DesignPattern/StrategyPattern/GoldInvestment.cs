using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Concrete Strategy 1 
    public class GoldInvestment : IInvestmentStrategy
    {
        public void Invest(double investMoney)
        {
            //Algorithmus wird hier hinterlegt
            Console.WriteLine($"Du hast {investMoney} in Gold investiert.");
        }
    }
}
