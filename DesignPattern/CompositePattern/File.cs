using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    // Leaf-Klasse
    public class File : FileSystemComponent
    {
        public string Owner {  get; set; }
        public File(string name, string owner)
        {
            Owner = owner;
            Name = name;
        }
        public override void Print()
        {
            Console.WriteLine($"Dateiname: {Name} Besitzer {Owner}");
        }
    }
}
