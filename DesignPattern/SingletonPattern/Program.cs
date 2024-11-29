namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Es darf von einer Klasse nur eine einzige Instanz erstellt werden 
            // Basic-Singleton: Objekt wird nur 1mal erzeugt

            BasicSingleton obj1 = BasicSingleton.getInstance();
            BasicSingleton obj2 = BasicSingleton.getInstance();

            // Lazy-Singleton: Erstellt nur ein Objekt, wenn es auch benötigt wird

            LazySingleton lazObj1 = LazySingleton.getInstance();
            LazySingleton lazObj2 = LazySingleton.getInstance();

            // Threadsafe-Singleton: Erweiterung des Lazy-Singleton um Threadsicherheit

            ThreadsafeSingleton threadObj1 = ThreadsafeSingleton.getInstance();
            ThreadsafeSingleton threadObj2 = ThreadsafeSingleton.getInstance();
        }
    }
}
