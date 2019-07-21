using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Afisaj : AbstractObserver
    {
        public Afisaj()
        {
            Update = (int temp) => { Console.WriteLine(temp); };
            Abonare();
        }
    }
}
