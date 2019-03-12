using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Croc : Animal
    {

        //TO DO: Andrei Manu - Add a constant to tell us the max weight of a prey
        //add a method to eat other animals of the master if they are small enough.
    
        const int MaxWeight = 200 ;
        
        public override void Feed()
        { 

            Console.WriteLine($"My pet name si {name} and he feeds whit humans");

        }
        public override void GrowOlder()
        {
            Console.WriteLine("He never get's old ");
        }

        public override void Move()
        {
            Console.WriteLine("He is very fast");
        }

        public override void Talk()
        {
            Console.WriteLine("He speaks English");
        }

        public Croc()
        {
            this.name = "Croky";
            this.age = 0;
            this.health = 400;
        }

        public override string ToString()
        {
            return base.ToString() + "Sunt regele mlastinii!";
        }
        public void Swim()
        {
            Console.WriteLine("I swim");
            energy--;
            if (energy > 0)
            {
                health++;
            }
            else
            {
                health--;
            }
        }
        public void ShowStatus()
        {
            Console.WriteLine("health = " + health + ", energy = " + energy);
        }
         
        

    }
}
