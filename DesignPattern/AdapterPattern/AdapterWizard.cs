using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //Adapter-Klasse
    public class AdapterWizard : IEnemyObject
    {
        private Wizard wizard;

        public AdapterWizard(Wizard wizard)
        {
            this.wizard = wizard;
        }
    
        public void Attack()
        {
            wizard.AttackPlayer();
        }

        public void SayHello()
        {
            wizard.Communicate();
        }

        public void Sleep()
        {
            wizard.Rest();
        }
    }
}
