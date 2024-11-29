using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // concrete Factory 1
    public class QuadroFactory : QuadrocopterFactory
    {
        public override Engine CreateEngine()
        {
            return new QuadroEngine();
        }

        public override Regulator CreateRegulator()
        {
            return new QuadroRegulator();
        }
    }
}
