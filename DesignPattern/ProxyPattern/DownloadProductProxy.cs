using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    //Schutz-Proxy - Proxy
    public class DownloadProductProxy : IDownloadable
    {
        private const int NUM_DOWNLOADS_ALLOWED = 3;
        private int numberDownloads = 0;
        private DownloadProduct downloadProduct;

        public DownloadProductProxy(string productName)
        {
            downloadProduct = new DownloadProduct(productName);
        }
        public void Download(Customer customer)
        {
            //hier findet die Schutzprüfung statt, wenn ok -> Methode von RealSubject aufrufen 
            if(numberDownloads < NUM_DOWNLOADS_ALLOWED)
            {
                numberDownloads++; 
                downloadProduct.Download(customer);
            }
            else
            {
                Console.WriteLine($"{downloadProduct.ProductName} wurde bereits zu oft heruntergeladen.");
            }
        }
    }
}
