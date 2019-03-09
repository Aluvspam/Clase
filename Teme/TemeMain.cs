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
            Cmmdc(20, 15);
            Console.Read();
        }

        static void CountDown(int num)
        {
            if (num < 0)
                return;

            Console.WriteLine(num + "...");
            CountDown(num - 1);
            Factorial factorial = new Factorial();
            
                

        }
        static int Cmmdc(int a, int b)
        {
             
            if (a==b)
            {
                return a;
            }
            return 1;
        }
        
    }
}
