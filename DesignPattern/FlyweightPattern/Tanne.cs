using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    //Concrete Implementation 2
    public class Tanne : ITree
    {
        private Color color;
        private TreeType treeType;

        //instrinsische Zustände = Werte, die sich mehrere Objekte teilen
        public Tanne()
        {
            color = Color.BROWN;
            treeType = TreeType.TANNE;

        }

        public void DrawTree(int x, int y, int height) // extrinsische Zustände = Werte, die für alle Objekte unterschiedlich sind
        {
            Console.WriteLine($"Tanne wird auf {x}, {y} mit einer Höhe von {height} gezeichnet");
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
