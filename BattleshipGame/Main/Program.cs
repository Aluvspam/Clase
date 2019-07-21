using Battleship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            var jucator = new Player();
            var c1 = new int[] { 7, 7, 7, 4, 4, 4, 9, 9, 6, 9, 9, 5, 5 };
            var c2 = new int[] { 3, 2, 1, 4, 4, 4, 5, 6, 5, 7, 8, 5, 6 };
            for (int i = 0; i < c1.Length; i++)
            {
                Console.WriteLine("fire at {0}, {1}", c1[i], c2[i]);
                Console.WriteLine(jucator.Attack(new Point(c1[i], c2[i])));
            }
            Console.ReadLine();
        }
    }
}
