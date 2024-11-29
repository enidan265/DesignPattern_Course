namespace FactoryMethodPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Logistik-Software soll unterschiedliche Transportwege anbieten 
            
            Logistics logisticsSoftware = new SeaRoadFlightLogistics();
            Transport kundenTransport = logisticsSoftware.ManageTransportForCustomer("sea");
        }
    }
}
