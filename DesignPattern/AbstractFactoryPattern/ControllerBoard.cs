using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    //fertiges Produkt 
    public class ControllerBoard
    {
        public Regulator MyRegulator { get; set; }
        public Engine MyEngine { get; set; }
        public QuadrocopterFactory UsedFactory { get; set; }

        public ControllerBoard(QuadrocopterFactory usedFactory)
        {
            UsedFactory = usedFactory;
            CreateParts();
        }

        public void CreateParts()
        {
            MyRegulator = UsedFactory.CreateRegulator();
            MyEngine = UsedFactory.CreateEngine();
        }
    }
}
