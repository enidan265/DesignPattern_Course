using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public interface ICalculateChainLink
    {
        void SetNextChainLink(ICalculateChainLink next);
        void Calculate(Numbers request);
    }
}
