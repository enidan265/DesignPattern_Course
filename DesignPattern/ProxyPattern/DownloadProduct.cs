using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    // Schutz-Proxy - Real Subject 
    public class DownloadProduct : IDownloadable
    {
        public string ProductName { get; set; }
        public DownloadProduct(string prdouctName)
        {
            ProductName = prdouctName;
        }
        public void Download(Customer customer)
        {
            Console.WriteLine($"{customer.Name} hat das Produkt {ProductName} heruntergeladen.");
        }
    }
}
