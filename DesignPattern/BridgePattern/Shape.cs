using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //Abstraktionshierarchie - abstrakte Klasse 
    public abstract class Shape
    {
        protected IDrawAPI drawAPI;
        public Shape(IDrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }

        public abstract void Draw();
    }
}
