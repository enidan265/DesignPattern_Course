using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    //Interface
    public interface ITree
    {
        Color GetColor();
        TreeType GetTreeType();
        void DrawTree(int x, int y, int height);
    }
}
