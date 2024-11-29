using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //Director
    public class CivilEngineer
    {
        private HouseBuilder builder;

        public CivilEngineer(HouseBuilder builder)
        {
            this.builder = builder;
        } 
        
        public void ConstructHouse()
        {
            builder.BuildBasement();
            builder.BuildMaterial();
            builder.BuildKitchen();
            builder.BuildRoof();
        }

        public House GetHouse()
        {
            return builder.GetHouse();
        }
    }
}
