using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace IteratorPattern
{
    //concrete Iterator
    public class ChannelIteratorNormal : IChannelIterator
    {
        private List<Channel> channels;
        private int currentPosition = 0;
        
        public ChannelIteratorNormal(List<Channel> channels)
        {
            this.channels = channels;
        }

        public bool HasNext()
        {
            if(currentPosition < channels.Count)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        public Channel Next()
        {
            return channels[currentPosition++];
        }
    }
}
