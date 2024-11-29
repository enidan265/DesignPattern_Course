namespace FlyweightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Speicheroptimierung, wenn man viele Objekte einer Klasse erstellen muss, die sich bestimmte variable Informationen teilen

            // Beispiel: Videospiel mit einem Wald, dafür braucht man sehr viele Baum-Objekte

            ITree tree1 = TreeFactory.GetTree(TreeType.TANNE);
            tree1.DrawTree(10, 20, 5);

            ITree tree2 = TreeFactory.GetTree(TreeType.TANNE);
            tree2.DrawTree(33, 22, 3);

            ITree tree3 = TreeFactory.GetTree(TreeType.BIRKE);
            tree3.DrawTree(15, 10, 6);

            ITree tree4 = TreeFactory.GetTree(TreeType.BIRKE);
            tree4.DrawTree(50, 220, 8);

            ITree tree5 = TreeFactory.GetTree(TreeType.TANNE);
            tree5.DrawTree(120, 240, 5);

        }
    }
}
