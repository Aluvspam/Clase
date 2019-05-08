using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class Afisaj
    {
        public void Afisare()
        {
            int oldTemperature = MeteoStation.Instance.Temperature;
            Console.WriteLine(oldTemperature);
            while (true)
            {
                int newTemperature = MeteoStation.Instance.Temperature;
                if (newTemperature != oldTemperature)
                {
                    oldTemperature = newTemperature;
                    Console.WriteLine(oldTemperature);
                }
            }
        }
    }
}
