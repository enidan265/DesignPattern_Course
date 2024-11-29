using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    // Memento Klasse
    public class Memento
    {
        private string typeOfTraining; 

        public Memento(string typeOfTraining)
        {
            this.typeOfTraining = typeOfTraining;
        }   

        //getState()
        public string GetState()
        {
            return typeOfTraining;
        }
    }
}
