using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    // Context Class
    public class Investment
    {
        private double investmentMoney;
        private bool talkedToBankEmployee = false;
        private IInvestmentStrategy investmentStrategy; 

        public Investment(double investmentMoney)
        {
            this.investmentMoney = investmentMoney;
        }

        public void SetInvestmentStrategy(IInvestmentStrategy investmentStrategy)
        {
            this.investmentStrategy = investmentStrategy;
            Console.WriteLine($"Die Strategie wurde geändert.");
        }

        public void TalkToBankEmployee()
        {
            talkedToBankEmployee = true;
            Console.WriteLine("Das Beratungsgespräch wurde durchgeführt");
        }

        //contextInterface()-Methode im UML-Klassendiagramm
        public void MakeInvestment()
        {
            if(investmentStrategy != null && talkedToBankEmployee)
            {
                investmentStrategy.Invest(investmentMoney);   
            }
            else
            {
                Console.WriteLine("Die Kriterien für ein Investment wurden noch nicht erfüllt.");
            }
        }
    }
}
