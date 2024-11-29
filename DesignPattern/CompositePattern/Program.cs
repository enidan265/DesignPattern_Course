namespace CompositePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // einfache und komplexe zusammengesetzte Objekte einheitlich behandeln 
            // Objekte werden zu Baumstrukturen zusammengefasst um so Teil-Ganze-Hierarchien zu repräsentieren

            // Beispiel: Dateisystem

            //Dateistruktur erstellen
            Directory videokurs = new Directory("Videokurs");
            File kursskript = new File("Kursskript", "Nadine");
            Directory videos = new Directory("Videos");
            videokurs.Add(kursskript);
            videokurs.Add(videos);
            File video1 = new File("Video1", "Nadine");
            File video2 = new File("Video2", "Nadine");
            videos.Add(video1);
            videos.Add (video2);

            //Aufruf
            videokurs.Print();
        }
    }
}
