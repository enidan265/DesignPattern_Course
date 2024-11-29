using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    public class Numbers
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public string Operator { get; set; }

        public Numbers(double number1, double number2, string @operator)
        {
            Number1 = number1;
            Number2 = number2;
            Operator = @operator;
        }
    }
}
