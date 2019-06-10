using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Exceptions
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            int nr = 0;
            do
            {
                Console.WriteLine("baga un int diferit de 0");
                try
                {
                    nr = Reading();

                    logger.Info("numarul este " + nr);
                }
                catch (MyException me)
                {
                    logger.Error("myExc message is " + me.MyField);
                }
                catch (Exception e)
                {
                    Console.WriteLine("nu inteleg numarul");
                    logger.Error("exception message is " + e.Message);
                }
                finally
                {
                    Console.WriteLine("asta se executa oricum");
                    logger.Trace("asta se executa oricum");
                }
            } while (nr == 0);
            Console.ReadLine();
            StreamReader se = null;
            try
            {
                se = new StreamReader("path.txt");
                logger.Trace("am deschis StreamReader catre path.txt");
                var v = int.Parse(se.ReadLine());
                var b = 3 / v;
            }
            catch (FileNotFoundException)
            {
                logger.Error("oopsie, eroare cand am vrut sa deschid StreamReader(\"path.txt\")");
            }
            catch (Exception)
            {
                Console.WriteLine("oopsie, eroare");
                logger.Error("oopsie, eroare");
            }
            finally
            {
                if (se != null)
                {
                    se.Close();
                    logger.Trace("am inchis StreamReader catre path.txt");
                }
                else
                {
                    logger.Warn("null StreamReader");
                }
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
