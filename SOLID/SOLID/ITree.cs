using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SOLID
{
    public interface ITree
    {
        Color GetColor();
        TreeType GetTreeType();

        void DrawTree(int x, int y, int height);
    }
}
