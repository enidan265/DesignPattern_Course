using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    // Caretaker
    public class Caretakter
    {
        private List<Memento> mementos; 

        public Caretakter()
        {
            mementos = new List<Memento>();
        }

        public void SaveState(FitnessPlan fitnessPlan)
        {
            mementos.Add(fitnessPlan.Save());
        }

        public void RestoreState(FitnessPlan fitnessPlan, int index)
        {
            fitnessPlan.Restore(mementos[index]);
        }

    }
}
