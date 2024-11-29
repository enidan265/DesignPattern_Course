using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //Implementor-Interface
    public interface IDrawAPI
    {
        void Draw(int x, int y, int width, int height);
    }
}
