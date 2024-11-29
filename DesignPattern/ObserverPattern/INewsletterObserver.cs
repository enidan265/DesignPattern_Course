using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // abstract Observer 
    public interface INewsletterObserver
    {
        public void Update(Newsletter newsletter);
    }
}
