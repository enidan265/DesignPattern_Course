using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class ThreadsafeSingleton
    {
        private static ThreadsafeSingleton instance;
        private static object lockobject = new object();

        private ThreadsafeSingleton()
        {
            Console.WriteLine("Der ThreadsafeSingleton wurde erstellt.");
        }

        public static ThreadsafeSingleton getInstance()
        {
            if (instance == null)
            {
                lock (lockobject) //stellt exklusiven Zugriff sicher 
                {
                    instance = new ThreadsafeSingleton();
                }
            }

            return instance;
        }
    }
}
