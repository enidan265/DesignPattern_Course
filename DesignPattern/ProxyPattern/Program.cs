namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Client kommuniziert nicht direkt mit Zielobjekt, sondern mit dem Proxy, welcher dann auf das Zielobjekt zugreift

            // Schutz-Proxy -> Zielobjekt wird zusätzliche Schutzebene hinzugefügt
            // Virtuelles Proxy -> Verbessert Performance

            // Beispiel Schutz-Proxy:   Download-Shop, Produkte können im Normalfall so oft heruntergeladen werden, wie man möchte. 
            //                          Neues Produkt soll allerdings nur 3x heruntergeladen werden können 

            Customer nadine = new Customer("Nadine", "Blastr. 11", true);

            DownloadProductProxy javaEbook = new DownloadProductProxy("Java E-Book");

            javaEbook.Download(nadine);
            javaEbook.Download(nadine);
            javaEbook.Download(nadine);
            javaEbook.Download(nadine); //hier wird der Download nicht mehr ausgeführt, weil Schutz-Proxy greift

            // Beispiel Virtuelles Proxy:   Verwaltungssoftware mit umfangreicher Kundenliste -> hoher Aufwand über Db darauf zuzugreifen. 
            //                              Proxy soll dafür sorgen, dass Kundenliste nur geladen wird, wenn wir sie auch brauchen.


            ICustomerList list = new CustomerListProxy();
            Company company = new Company("Haralds Bauwaren", "Baustr. 34", list); //hier wird noch keine Liste geladen

            Console.WriteLine(company.Name);

            List<Customer> customerList = list.GetCustomerList(); //erst hier wird Liste geladen, wenn diese auch wirklich angeforder wurde 

            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer);
            }



        }
    }
}
