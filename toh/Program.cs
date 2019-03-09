using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoy
{
    class Program
    {
        static void Main(string[] args)
        {
            char start = 'A'; // start tower in output
            char end = 'C'; // end tower in output
            char temp = 'B'; // temporary tower in output
            int totalDisks = 3; // number of disks

            SolveTowers(totalDisks, start, end, temp);
            Console.Read();
        }

        public static void SolveTowers(int n, char start, char end, char temp)
        {
            if (n > 0)
            {
                SolveTowers(n - 1, start, temp, end);
                Console.WriteLine("Move disk from " + start + ' ' + end);
                SolveTowers(n - 1, temp, end, start);

            }
        }
    }
}
