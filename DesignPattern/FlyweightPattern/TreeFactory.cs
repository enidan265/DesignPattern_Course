using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    //Factory
    public class TreeFactory
    {
        // Objekte werden in Dictionary gespeichert, weil effektives Speichermedium
        public static Dictionary<TreeType, ITree> treeDictionary = new Dictionary<TreeType, ITree>();

        public static ITree GetTree(TreeType treeType)
        {
            if(!treeDictionary.ContainsKey(treeType)) //Objekte werden nur erstellt, wenn von diesem Typ noch kein Objekt vorhanden ist
            {
                ITree tree = null;
                switch (treeType)
                {
                    case TreeType.TANNE:
                        tree = new Tanne();
                        Console.WriteLine("Tanne wurde erstellt");
                        break;
                    case TreeType.BIRKE:
                        tree = new Birke();
                        Console.WriteLine("Birke wurde erstellt");
                        break;
                }

                if(tree == null)
                {
                    throw new Exception("Ungültiger TreeType");
                }
                treeDictionary[treeType] = tree;
            }

            return treeDictionary[treeType];
        }
    }
}
