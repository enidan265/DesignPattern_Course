using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Aufgabe1
{
    public class StandardInterestRate
    {
        private static StandardInterestRate instance;

        public float interestRate {  get; set; }

        private static object lockobject = new object();

        private StandardInterestRate() 
        {
            interestRate = 3;
        }


        public static StandardInterestRate GetInstance()
        {
            lock (lockobject)
            {
                if (instance == null)
                {
                    instance = new StandardInterestRate();
                }
            }
            return instance;
        }
    }
}
