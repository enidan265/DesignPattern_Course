using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    // Virtueller Proxy - RealSubject
    public class CustomerList : ICustomerList
    {
        public List<Customer> GetCustomerList()
        {
            List<Customer> customerList = new List<Customer>();

            //hier wäre der automatische Datenbankzugriff, ersetzt durch manuelle Datenerstellung
            customerList.Add(new Customer("Sabrina Mager", "Ahastr.789", false));
            customerList.Add(new Customer("Max Mager", "Blastr.789", true));
            customerList.Add(new Customer("Dagmar Steffens", "Ohostr.789", true));
            Console.WriteLine("Kundenliste wurde geladen");

            return customerList; 

        }
    }
}
