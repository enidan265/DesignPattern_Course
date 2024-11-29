using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Channel
    {
        public string Name { get; set; }
        public double Frequency { get; set; }

        public Channel(string name, double frequency)
        {
            Name = name;
            Frequency = frequency;
        }

        public override string ToString()
        {
            return $"Du hörst gerade {Name}({Frequency})";
        }

    }
}
