using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    // Virtueller Proxy - Interface
    public interface ICustomerList
    {
        List<Customer> GetCustomerList();
    }
}
