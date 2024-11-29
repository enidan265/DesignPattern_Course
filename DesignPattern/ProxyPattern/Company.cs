using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ICustomerList CustomerList { get; set; }

        public Company(string name, string address, ICustomerList customerList)
        {
            Name = name;
            Address = address;
            CustomerList = customerList;
        }
    }
}
