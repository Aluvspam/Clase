using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scaun
{
    class Program
    {
        static void Main(string[] args)
        {
            Scaun S = new Scaun();
            Scaun S2 = new Scaun();

            var V = new char [12] {'1', '3', '6', '7', 'A', 'b', 'd', 'E', 'F', 'g', '8', 'W'};
            var result = new List<char>();

            result = ProblemaInterviu(V);
        }

        public static List<char> ProblemaInterviu(char[] V)
        {
            var target = new List<char>();

            foreach (var item in V)
            {
                if (item >= 'A' && item <= 'Z')
                {
                    target.Add(item);
                }
            }

            return target;
        } 

    }
}
