using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Curs15.Decorator.Tema;

namespace EventsAndDelegates
{
    public class ProfusDelegate
    {
        void RunMultipleTimes(int steps)
        {
            for (int i = 0; i < steps; i++)
            {
                TemaRunExamples.exampluQueue();
            }
        }
        static void AfisareNumar(int numar)
        {
            Console.WriteLine(numar);
        }
        public static void AltaMetoda()
        {
            Afisaj afisaj = new Afisaj();
            while (true)
            {
                MeteoStation.Instance.Run();
                afisaj.Afisare();
            }
            var del = new ProfusDelegate();
            AndreisDelegate ad1 = del.RunMultipleTimes;
            AndreisDelegate ad2 = AfisareNumar;
            Bum += ad1;
            Bum += ad2;
            ad1(2);
            ad2(4);
            ad2.Invoke(8);
            var i = 0;
            while (i < 3)
            {
                Console.WriteLine("introdu ceva");
                var ceva = Console.ReadLine();
                if (ceva == "Bum")
                {
                    if (Bum != null)
                    {
                        Bum.Invoke(i);
                    }
                    Console.WriteLine("Am invocat Bum ({0})", i);
                    i++;
                }
            }
            Console.WriteLine("gata while-ul");
        }
        public static event AndreisDelegate Bum;
    }
}
