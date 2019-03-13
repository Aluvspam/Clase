using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Chicken : Animal
    {
        //TO DO: Liviu to add code here (fields, variables, methods constructor(s)
        // add a field/property to tell egg laying capacity of a chicken (eggs / week) you can use health and age to calculate this
        //add a method that lays eggs
        //add a field that tell us the cost of an egg
        public override void Feed()
        {
            string name = "Chicky";
            Console.WriteLine($"I like to eat other chickens i'm called {name}");
        }

        public override void GrowOlder()
        {
            int age = 4;
            Console.WriteLine(age);
        }

        public override void Move()
        {
            string movement = "peste tot";
            Console.WriteLine(movement);
        }

        public override void Talk()
        {
            var language = "Cotcodack!!!";
            Console.WriteLine(language);
        }

        public Chicken()
        {
            return;
        }
        //TO DO: Add comment to explain what this method does
        public int Eggs()
        {
            //TO DO: add comments to explain the variables used below
            int day = 1;
            int week = day * 7;
            int layeggs = 1;
            int egg = 2;
            int eggs = layeggs * day;
            int eggs2 = egg * eggs;

            if (health >= 0 && age <= 8)
            {
                if (health >= 50)
                    return eggs * 2;
                return eggs;
            }
            else
                return 0;

        }
    }
}
