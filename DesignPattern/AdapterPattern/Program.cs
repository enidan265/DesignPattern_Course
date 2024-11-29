namespace AdapterPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Wir haben ein Spiel mit unterschiedlichen Gegnern, die alle ein Interface implementieren.
            // Nun soll ein Gegner eines anderen Entwicklers implementiert werden, der nicht kompatibel mit unserem Interface ist. 

            IEnemyObject goblin = new Goblin();

            goblin.Attack();
            goblin.SayHello();
            goblin.Sleep();

            IEnemyObject wizard = new AdapterWizard(new Wizard());
            wizard.Attack();
            wizard.SayHello();
            wizard.Sleep();

        }
    }
}
