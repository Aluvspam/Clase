using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.ChainOfResponsibility;
namespace Teme
{
    class TemeMain
    {
        static void Main(string[] args)
        {
            ExempluCoR();
            //StateProject.Client.Run();
            Curs15.Decorator.Tema.TemaRunExamples.Run();
            int[] arr = new int[40];
            //CountDown(20);
            Curs15.Decorator.RunExamples.Run();
            Console.WriteLine(Euclid(30, 20));
            Console.WriteLine(Cmmdc(arr));

            Cmmdc(20, 15);
            Console.Read();
        }
        static void ExempluCoR()
        {
            var myMessage = new Message() { Body = "iii", language = "Roman" };
            var myMessage2 = new Message() { Body = "xi", language = "Roman" };
            var myMessage3 = new Message() { Body = "One", language = "Eng" };
            Message[] mesaje = new Message[] { myMessage, myMessage2, myMessage3, new Message() { Body = "doi", language = "Ro" } };
            var myHandler = new RomanHandler();
            myHandler.nextHandler = new RoHandler();
            foreach (var mesaj in mesaje)
            {
                Console.WriteLine(myHandler.Handle(mesaj));
            }
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
            if (a == b)
            {
                return a;
            }
            if (a > b)
            {
                return Cmmdc(b, a - b);
            }
            else
            {
                return Cmmdc(a, b - a);
            }
        }

        static int Cmmdc(int[] arr)
        {
            //conditia de terminare / stop
            if (arr.Length <= 2)
            {
                if (arr.Length == 0)
                {
                    return 0; //TO DO: write code for cases when arr has no elements// Done
                }
                else
                {

                    return Cmmdc(arr[0], arr[arr.Length - 1]);
                }
            }
            int[] numere = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length - 2; i++)
            {
                numere[i] = arr[i];
            }
            numere[arr.Length - 2] = Cmmdc(arr[arr.Length - 2], arr[arr.Length - 1]);
            return Cmmdc(numere);
        }

        static int Euclid(int a, int b)
        {
            int c;

            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
    }
}
