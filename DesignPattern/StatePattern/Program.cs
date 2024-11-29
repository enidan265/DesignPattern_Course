namespace StatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Mit dem StatePattern kann man das Verhalten eines Objekts zur Laufzeit ändern, und wzar immer dann, wenn sich der interne Zustand
            // des Objekts geändert hat. Es wird dann so aussehen, als ob das Objekt seine Klasse geändert hat 

            // Beispiel: Amphibienfahrzeug, dass an Land und im Wasser fahren kann. Je nach Status (Land oder Wasser) ändert sich die Art der Fortbewegung

            AmphibiousVehicle vehicle = new AmphibiousVehicle();
            vehicle.Accelarate();
            vehicle.SlowDown();
            Console.WriteLine();
            vehicle.PrepareForWater();
            vehicle.Accelarate();
            vehicle.SlowDown();
            Console.WriteLine();
            vehicle.PrepareForLand();
            vehicle.Accelarate();
            vehicle.SlowDown();
        }
    }
}
