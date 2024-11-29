using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    // concrete Aggregate
    public class CarRadio : IChannelCollection
    {
        private List<Channel> channels;

        public CarRadio()
        {
            this.channels = new List<Channel>();
        }

        public IChannelIterator CreateIterator()
        {
            ChannelIteratorShuffle iterator = new ChannelIteratorShuffle(channels);
            return iterator;
        }

        public void AddChannel(Channel channel)
        {
            channels.Add(channel);
        }

        public void RemoveChannel(Channel channel)
        {
            channels.Remove(channel);
        }
    }
}
