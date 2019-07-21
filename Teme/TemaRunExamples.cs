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
            Action exampleDrink = ExampleDrinks;
            Action exempluPizza = examplePizza;
            exampleDrink.Invoke();
            Action[] actions = new Action[] { exampleDrink, exempluPizza, exampluQueue };
            foreach (var action in actions)
            {
                action.Invoke();
            }
            Console.ReadLine();
        }
        static void ExampleDrinks()
        {
            IDrink gin = new Gin();
            IJuice orange = new Orange { Component = gin };
            Console.WriteLine("ginOrange name = " + orange.GetName());
            Console.WriteLine("ginOrange volume = " + orange.GetQuantity());
            Console.WriteLine("ginOrange price = " + orange.GetCost());
            IJuice tonic = new Tonic { Component = gin };
            Console.WriteLine("ginTonic name = " + tonic.GetName());
            Console.WriteLine("ginTonic volume = " + tonic.GetQuantity());
            Console.WriteLine("ginTonic price = " + tonic.GetCost());
        }
        static void examplePizza()
        {
            //codul aici
        }
        public static void exampluQueue()
        {
            Queue<int> myQueue = new Queue<int>();
            myQueue.Enqueue(17);
            myQueue.Enqueue(19);
            Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine(myQueue.Count);
        }
    }
}
