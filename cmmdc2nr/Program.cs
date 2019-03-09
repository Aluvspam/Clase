using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmmdc2nr
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr1, nr2, n, m;
            Console.Write("Introduceti primul numar: ");
            nr1 = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar: ");
            nr2 = int.Parse(Console.ReadLine());
            n = nr1; m = nr2;
            while (nr1 != nr2)
                if (nr1 > nr2)
                    nr1 -= nr2;
                else
                    nr2 -= nr1;
            Console.WriteLine("c.m.m.d.c. ({0},{1}) = {2}", n, m, nr1);
            Console.ReadLine();
        }       
    }
}
