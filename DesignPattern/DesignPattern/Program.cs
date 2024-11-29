using BuilderPattern;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Beispiel: Ein Kunde gibt bei einem Bauingenieur ein Haus in Auftrag.
            //          Dieser hat zwei fertige Baulösungen:
            //          Holzhaus & Steinhaus 

            WoodHouseBuilder whb = new WoodHouseBuilder();
            CivilEngineer engineer = new CivilEngineer(whb);

            engineer.ConstructHouse();

            House myWoodHouse = engineer.GetHouse();
            Console.WriteLine(myWoodHouse);

        }
    }
}
