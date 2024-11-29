using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Birke : ITree
    {
        private Color color; 
        private TreeType treeType;

        public Birke()
        {
            color = Color.WHITE;
            treeType = TreeType.BIRKE;
        }
        
        public void DrawTree(int x, int y, int height)
        {
            Console.WriteLine($"Birke wird auf {x}, {y} mit einer Höhe von {height} gezeichnet.");
        }

        public Color GetColor()
        {
            return color;
        }

        public TreeType GetTreeType()
        {
            return treeType;
        }
    }
}
