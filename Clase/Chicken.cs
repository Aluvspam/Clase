using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Chicken : HunterAnimal
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

        public int LayingEggsCapacity()
        {            
            int day = 1;
            int layeggs = 1;
            int eggprice = 2;
            int eggs = layeggs * day;
            int incomeforeggs = eggprice * eggs;
            
            if (health >= 0 && age <= 8)
            {
                if (health >= 50)
                    return eggs * 2;
                return eggs + incomeforeggs;
            }
            else
                return 0;

        }
    }
}
