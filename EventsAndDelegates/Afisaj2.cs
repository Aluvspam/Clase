using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Afisaj2 : AbstractObserver
    {
        public Afisaj2()
        {
            Update = Afisare;
            Abonare();
        }
        public void Afisare(int x)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("temperatura este {0}, {1}", x, ((x < -20) ? "brrr" : "putea fi mai rau"));
            }
        }
    }
}
