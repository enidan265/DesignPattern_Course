
namespace IteratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bereitstellen einer Standardmethode um eine Gruppe von Objekten zu durchlaufen 

            // Beispiel: Autoradio, das eine Liste von Kanälen hat, die durchlaufen werden sollen 

            IChannelCollection radio = new CarRadio();
            radio.AddChannel(new Channel("DJHorstFM", 106.4));
            radio.AddChannel(new Channel("CloudFM", 103.1));
            radio.AddChannel(new Channel("Antenne Aktiv", 101.1));

            IChannelIterator iterator = radio.CreateIterator();

            while (iterator.HasNext())
            {
                Channel channel = iterator.Next();
                Console.WriteLine(channel);
            }

        }
    }
}
