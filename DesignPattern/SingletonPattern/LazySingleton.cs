using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class LazySingleton
    {
        private static LazySingleton instance;

        private LazySingleton()
        {
            Console.WriteLine("Der LazySingleton wurde erstellt.");
        }

        public static LazySingleton getInstance()
        {
            if(instance == null)
            {
                instance = new LazySingleton();
            }
            return instance;
        }
    }
}
