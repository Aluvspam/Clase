﻿using System;
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

            var V = new char[12] { '1', '3', '6', '7', 'A', 'b', 'd', 'E', 'F', 'g', '8', 'W' };
            int a = 7;
            int b = 9;
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            swapL(ref a, ref b);

            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);
            var result = new List<char>();

            var arr = new int[] { 5, 1, 11, 3, 6, 7, 10, 13, 8 };
            BubbleSort(arr);

            result = ProblemaInterviu(V);
            Console.ReadLine();
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

            return target.ToArray().ToList();
        }
        public static void swapL(ref int a, ref int b)
        {
            int c = b;
            b = a;
            a = c;
        }

        public static void swapT(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        public static void BubbleSort(int[] NumeArray)
        {
            int swapped;
            int n = NumeArray.Length -1;
            do
            {
                swapped = 0;

                for (int i = 0; i <= n - 1; i++)
                {
                    if (NumeArray[i] > NumeArray[i + 1])
                    {
                        swapL(ref NumeArray[i], ref NumeArray[i + 1]);
                        swapped = 1;
                    }
                    
                }
                n--;
            }
            while (swapped == 1);

            for (int i = 0; i < NumeArray.Length; i++)
            {
                Console.WriteLine(NumeArray[i] + " ");
            }
        }
    }
}
