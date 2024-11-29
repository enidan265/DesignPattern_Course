using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    // abstract Aggregate
    public interface IChannelCollection
    {
        void AddChannel(Channel channel);
        void RemoveChannel(Channel channel);
        IChannelIterator CreateIterator();
    }
}
