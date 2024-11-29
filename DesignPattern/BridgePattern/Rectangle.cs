using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    //Abstraktionshierarchie - Refined Abstraction
    public class Rectangle : Shape
    {
        private int x; 
        private int y; 
        private int width;
        private int height;
        public Rectangle(IDrawAPI drawAPI, int x, int y, int width, int height) : base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override void Draw()
        {
            drawAPI.Draw(x, y, width, height);
        }
    }
}
