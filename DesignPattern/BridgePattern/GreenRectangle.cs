using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //Implementierungshierarchie - Klasse mit konkreter Implementierung
    public class GreenRectangle : IDrawAPI
    {
        public void Draw(int x, int y, int width, int height)
        {
            Console.WriteLine($"Das grüne Rechteck" +
                $"wurde an Position {x}, {y}, mit einer " +
                $"Breite von {width} und einer " +
                $"Höhe von {height} gezeichnet.");
        }
    }
}
