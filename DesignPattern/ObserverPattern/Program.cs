namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definition einer Abhängigkeit zwischen einem und beliebig vielen Objekten
            // Zustandsänderung des einen Objekts führt zu Benachrichtigung der abhängigen Objekte und deren Aktualisierung

            // Beispiel: Newsletter

            SportNewsletter sn = new SportNewsletter(new Newsletter("Tipps für dein Training", "Inhalt..."));

            Person person1 = new Person("Nadine");
            Person person2 = new Person("Sabie");
            Person person3 = new Person("Max");


            sn.Subscribe(person1);
            sn.Subscribe(person2);

            sn.SetNewsletter(new Newsletter("Olympische Spiele", "Inhalt..."));

            sn.Unsubscribe(person1);
            sn.Subscribe(person3);

            sn.SetNewsletter(new Newsletter("WM 2018", "Inhalt..."));
        }
    }
}
