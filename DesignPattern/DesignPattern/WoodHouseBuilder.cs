using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //ConcreteBuilder Klasse für Variante 1 
    public class WoodHouseBuilder : HouseBuilder
    {
        private House house = new House();

        public override void BuildBasement()
        {
            house.Basement = "Steinkeller mit Strom und Wasserleitung";
        }

        public override void BuildKitchen()
        {
            house.Kitchen = "Küche mit edlen Holzelementen";
        }

        public override void BuildMaterial()
        {
            house.Material = "Holz";
        }

        public override void BuildRoof()
        {
            house.Roof = "Holzdach";
        }

        public override House GetHouse()
        {
            return house;
        }
    }
}
