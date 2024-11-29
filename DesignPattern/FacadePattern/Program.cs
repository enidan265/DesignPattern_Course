namespace FacadePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // bietet eine einheitliche und meist vereinfachte Schnittstelle zu einer Menge von Schnittstellen eines Subsystems

            // Beispiel: Fluggast gibt ein Gepäck am Flughafen ab und es soll bis zum Hotel gebracht werden.
            //              --> System braucht viele Subsysteme um Prozess durchzuführen (Flughafen, Flugzeug, Logistiker, Hotel)

            FacadeLuggageManagement bookingSystem= new FacadeLuggageManagement();
            bookingSystem.SendLuggage();

        }
    }
}
