namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Trennung von Abstraktions- & Implementierungshierachie 
            // Beide Hierarchien können von einander getrennt weiterentwickelt werden 

            // Beispiel: Shape - Rectangle 

            Shape greenRectangle = new Rectangle(new GreenRectangle(), 100, 200, 32, 32);
            greenRectangle.Draw();
        }
    }
}
