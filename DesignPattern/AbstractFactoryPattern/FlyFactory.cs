using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    // concrete Factory 2
    public class FlyFactory : QuadrocopterFactory
    {
        public override Engine CreateEngine()
        {
            return new FlyEngine();
        }

        public override Regulator CreateRegulator()
        {
            return new FlyRegulator();
        }
    }
}
