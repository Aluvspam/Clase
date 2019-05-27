using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr = 0;
            do
            {
                Console.WriteLine("baga un int diferit de 0");
                try
                {
                    nr = Reading();

                    Console.WriteLine("numarul este " + nr);
                }
                catch (MyException me)
                {
                    Console.WriteLine("myExc message is " + me.MyField);
                }
                catch (Exception e)
                {
                    Console.WriteLine("nu inteleg numarul");
                    Console.WriteLine("exception message is " + e.Message);
                }
                finally
                {
                    Console.WriteLine("asta se executa oricum");
                }
            } while (nr == 0);
            Console.ReadLine();
            StreamReader se = new StreamReader("path.txt");
            try
            {
                var v = int.Parse(se.ReadLine());
                var b = 3 / v;
            }
            catch (Exception)
            {
                Console.WriteLine("oopsie, eroare");
            }
            finally
            {
                se.Close();
            }
        }
        static int Reading()
        {
            int nr;
            nr = int.Parse(Console.ReadLine());
            if (nr == 0)
            {
                MyException exc = new MyException();
                exc.MyField = "zero nu e bine";
                throw exc;
            }
            return nr;
        }
    }
    class MyException : Exception
    {
        public string MyField;
    }
}
