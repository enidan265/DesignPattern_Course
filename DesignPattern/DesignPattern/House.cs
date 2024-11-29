using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    //Product-Klasse 
    public class House
    {
        public string Material {  get; set; }
        public string Basement { get; set; }
        public string Kitchen {  get; set; }
        public string Roof { get; set; }

        public override string ToString()
        {
            string output = $"Material: {Material} \n" +
                $"Basement: {Basement} \n" +
                $"Kitchen: {Kitchen} \n" +
                $"Roof: {Roof}";

            return output;
        }
    }
}
