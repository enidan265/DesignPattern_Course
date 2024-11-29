using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    // Concrete Handler 1
    public class AddOperation : ICalculateChainLink
    {
        private ICalculateChainLink nextChainLink;

        public void Calculate(Numbers request)
        {
            if(request.Operator == "+")
            {
                double result = request.Number1 + request.Number2;
                Console.WriteLine($"{request.Number1} + {request.Number2} = {result}");
            }
            else
            {
                nextChainLink.Calculate(request);
            }
        }

        public void SetNextChainLink(ICalculateChainLink next)
        {
            nextChainLink = next;
        }
    }
}
