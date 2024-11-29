using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // concrete Observer
    public class Person : INewsletterObserver
    {
        private string name;
        private Newsletter currentNewsletter;

        public Person(string name)
        {
            this.name = name;
        }

        public void Update(Newsletter newsletter)
        {
            currentNewsletter = newsletter;
            Console.WriteLine($"{name} hat den neuen Newsletter zum Thema: {currentNewsletter.Topic} erhalten");
        }
    }
}
