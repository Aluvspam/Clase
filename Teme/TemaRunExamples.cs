using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs15.Decorator.Tema
{
    public class TemaRunExamples
    {
        public static void Run()
        {
            IDrink gin = new Gin();
            IJuice orange = new Orange { Component = gin };
            Console.WriteLine("ginOrange volume = " + orange.GetQuantity());
            Console.WriteLine("ginOrange price = " + orange.GetCost());
            Console.ReadLine();
        }
    }
}
