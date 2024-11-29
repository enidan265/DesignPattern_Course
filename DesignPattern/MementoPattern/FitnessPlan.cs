using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    // Originator
    public class FitnessPlan
    {
        private string typeOfTraining; 

        public FitnessPlan(string typeOfTraining)
        {
            this.typeOfTraining = typeOfTraining;
        }   

        public void ChangeTypeOfTraining(string typeOfTraining)
        {
            this.typeOfTraining = typeOfTraining;
        }

        public override string ToString()
        {
            return $"Trainingsart: {this.typeOfTraining}";
        }

        // createMemento() : Memento
        public Memento Save()
        {
            Console.WriteLine("Zustand wurde gespeichert");
            return new Memento(this.typeOfTraining);
        }

        //setMemento(memento: Memento)
        public void Restore(Memento saveState)
        {
            Console.WriteLine("Zustand wurde wiederhergestellt");
            this.typeOfTraining = saveState.GetState();
        }
    }
}
