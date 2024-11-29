using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    // Schutz-Proxy - Interface
    public interface IDownloadable
    {
        void Download(Customer customer);
    }
}
