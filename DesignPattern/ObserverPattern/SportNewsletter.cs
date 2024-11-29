using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // concrete Subject
    public class SportNewsletter : NewsletterSubject
    {
        private Newsletter currentNewsletter; 

        public SportNewsletter(Newsletter newsletter)
        {
            this.currentNewsletter = newsletter;
        }

        //getState()-Methode aus dem UML-Klassendiagramm
        public Newsletter GetNewsletter()
        {
            return currentNewsletter;
        }

        //setState()-Methode aus dem UML-Klassendiagramm 
        public void SetNewsletter(Newsletter newNewsletter)
        {
            this.currentNewsletter = newNewsletter;
            Console.WriteLine("Es ist ein neues Newsletter erschienen");
            SendNewsletter(currentNewsletter); //Aufruf der notify()-Methode der abstrakten Subjekt-Klasse 
        }
    }
}
