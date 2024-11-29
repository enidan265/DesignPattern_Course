using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    // Virtueller Proxy - Proxy
    public class CustomerListProxy : ICustomerList
    {
        private ICustomerList customerList;

        public List<Customer> GetCustomerList()
        {
            // ist die Liste noch nicht geladen? 
            if(customerList == null)
            {
                Console.WriteLine("Die Kundenliste wird geladen");
                customerList = new CustomerList();
            }

            return customerList.GetCustomerList();
        }
    }
}
