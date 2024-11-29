using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //ConcreteBuilder Klasse für Variante 2
    public class StoneHouseBuilder : HouseBuilder
    {
        private House house = new House();

        public override void BuildBasement()
        {
            house.Basement = "Steinkeller mit Strom und Wasserleitung";
        }

        public override void BuildKitchen()
        {
            house.Kitchen = "Küche mit edlen Steinwänden";
        }

        public override void BuildMaterial()
        {
            house.Material = "Stein";
        }

        public override void BuildRoof()
        {
            house.Roof = "Steinernes Dach";
        }

        public override House GetHouse()
        {
            return house;
        }
    }
}
