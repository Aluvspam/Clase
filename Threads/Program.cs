using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace Threads
{
    class Program
    {
        static int v;
        static int n;
        static int grrr = -1;
        static object lacat = new object();
        //static string filename;
        static void Main()
        {
            Console.WriteLine("cate fisiere?");
            v = int.Parse(Console.ReadLine());
            Console.WriteLine("cate caractere fiecare");
            n = int.Parse(Console.ReadLine());
            DateTime d = DateTime.Now;
            for (int i = 0; i < v; i++)
            {
                Console.WriteLine("creating thread " + i);
                Thread thread = new Thread(CreateFile);
                thread.Name = i.ToString();
                Console.WriteLine("starting thread " + i);
                thread.Start();
            }
            //var timePassed = DateTime.Now - d;
            //Console.WriteLine(timePassed);
            //CountDivisibleWith3("fisier0.txt");
            //Console.WriteLine(DateTime.Now - d);
            //Console.ReadLine();
        }

        static void CreateFile(string name, int caractere)
        {
            Thread.Sleep(1);
            Thread t = Thread.CurrentThread;
            Console.WriteLine("Running thread " + t.Name + ", filename is " + name);
            if (File.Exists(name))
            {
                File.Delete(name);
            }
            //File.Create(name);
            StreamWriter sw = new StreamWriter(name, true);
            Random r = new Random();
            for (int i = 0; i < caractere; i++)
            {
                sw.Write(r.Next(10));
            }
            sw.Close();
        }

        static void CreateFile()
        {
            string name = filename();
            Thread t = Thread.CurrentThread;
            Console.WriteLine("Running thread " + t.Name + ", filename is " + name);
            if (File.Exists(name))
            {
                File.Delete(name);
            }
            StreamWriter sw = new StreamWriter(name, true);
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                sw.Write(r.Next(10));
            }
            sw.Close();
            Console.WriteLine("finished running thread " + t.Name + ", filename is " + name);
        }

        private static string filename()
        {
            lock (lacat)
            {
                grrr++;
                return "fisier" + grrr + ".txt";
            }
        }

        static void CountDivisibleWith3(string path)
        {
            string txt;
            //more elegant
            using (StreamReader se = new StreamReader(path))
            {
                txt = se.ReadToEnd();
            }
            int counter = 0;
            for (int i = 0; i < txt.Length; i++)
            {
                if (int.Parse(txt[i].ToString()) % 3 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine("am gasit {0} cifre divizibile cu 3", counter);
        }
    }
}
