using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Teme
{
    class TemeMain
    {
        static void Main(string[] args)
        {
            CountDown(20);
            Console.Read();
        }

        static void CountDown(int num)
        {
            if (num < 0)
                return;

            Console.WriteLine(num + "...");
            CountDown(num - 1);

            Factorial factorial = new Factorial();
            Console.WriteLine(factorial.Factorial1(3));
                

        }

        static int Cmmdc(int a, int b)
        {
            if (a > b)
            {
                return Cmmdc(b,a-b);
            }


            else
            {
                return Cmmdc(a, b - a);
            }
        }

        static int Cmmdc (int a, int b) {
           return 1;
        }

        static int euclid(int a, int b)
        {
            int c;
            while (b) {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
    }
}
