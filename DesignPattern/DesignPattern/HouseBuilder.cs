using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //abstrakte Builder-Klasse
    public abstract class HouseBuilder
    {
        public abstract void BuildMaterial();
        public abstract void BuildBasement();
        public abstract void BuildKitchen();
        public abstract void BuildRoof();
        public abstract House GetHouse();
    }
}
