namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ein Produkt bestehend aus Regulator + Engine  wird von zwei Firmen hergestellt 
            // Firma1: FlyCompany
            // Firma2: Quadrocompany

            QuadrocopterFactory flyFactory = new FlyFactory();

            ControllerBoard controller = new ControllerBoard(flyFactory);

        }
    }
}
