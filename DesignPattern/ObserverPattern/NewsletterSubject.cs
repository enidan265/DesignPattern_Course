using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    // abstract Subject
    public abstract class NewsletterSubject
    {
        private List<INewsletterObserver> observers = new List<INewsletterObserver>();

        public void Subscribe(INewsletterObserver observer)
        {
            //prüfen ob Observer bereits vorhanden
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
        }

        public void Unsubscribe(INewsletterObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        //notify()-Methode in UML-Diagramm
        public void SendNewsletter(Newsletter newNewsletter)
        {
            foreach(INewsletterObserver observer in observers)
            {
                observer.Update(newNewsletter);
            }
        }
    }
}
