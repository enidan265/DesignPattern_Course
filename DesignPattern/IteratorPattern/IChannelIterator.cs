using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    // abstract Iterator
    public interface IChannelIterator
    {
        bool HasNext();
        Channel Next();
    }
}
