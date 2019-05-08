using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class MeteoStation
    {
        int temperature;
        Random r;
        static MeteoStation instance;
        public int Temperature
        {
            get
            {
                return temperature;
            }
        }
        public MeteoStation()
        {
            temperature = 0;
            r = new Random();
        }
        public static MeteoStation Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MeteoStation();
                }
                return instance;
            }
        }
        public void Run()
        {
            var a = Instance.r.Next(77);
            if (a == 0)
            {
                temperature--;
            }
            else if (a == 76)
            {
                temperature++;
            }
            else if (temperature > 0 && a == 1)
            {
                temperature--;
            }
            else if (temperature < -40 && a == 75)
            {
                temperature++;
            }
        }
    }
}
