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
            Console.WriteLine("ginOrange name = " + orange.GetName());
            Console.WriteLine("ginOrange volume = " + orange.GetLongDrinkQuantity());
            Console.WriteLine("ginOrange price = " + orange.GetCost());
            IJuice tonic = new Tonic { Component = gin };
            Console.WriteLine("ginTonic name = " + tonic.GetName());
            Console.WriteLine("ginTonic volume = " + tonic.GetLongDrinkQuantity());
            Console.WriteLine("ginTonic price = " + tonic.GetCost());
            Console.ReadLine();
        }
    }
}
