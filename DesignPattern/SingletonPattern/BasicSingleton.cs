using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class BasicSingleton
    {
        private static readonly BasicSingleton instance = new BasicSingleton();

        private BasicSingleton()
        {
            Console.WriteLine("Der BasicSingleton wurde erstellt.");
        }
        public static BasicSingleton getInstance()
        {
            return instance;
        }

    }
}
