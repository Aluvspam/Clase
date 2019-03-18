using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Croc : HunterAnimal
    {

        //TO DO: Andrei Manu - Add a constant to tell us the max weight of a prey
        //add a method to eat other animals of the master if they are small enough.

        const float MaxWeight = 500;
        private static int crocCount;

        public override void Feed()
        {

            Console.WriteLine($"My pet name si {name} and he feeds with humans");

        }
        public override void GrowOlder()
        {
            Console.WriteLine("Croc is getting older when Andrei skips classes");
            age++;
            weight *= .99;
            if (energy > 11)
            {
                energy -= 10;
            }
            else
            {
                energy = 1;
                health -= 10 - (energy - 1);
            }
            if (health < 1)
            {
                health = 0;
                energy = 0;
                if (owner != null)
                {
                    owner.Pets.Remove(this);
                }
            }
        }

        public override void Move()
        {
            Console.WriteLine("He is very fast");
        }

        public override void Talk()
        {
            Console.WriteLine("He speaks English");
        }

        public Croc(string name) : base()
        {
            this.name = name;
            age = 0;
            health = 100;
            weight = 608;
            crocCount++;
            energy = 100;
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

        public override void EatAnimal()
        {
            var pets = this.owner.Pets;
            var petsEat = 0;

            foreach (var pet in pets)
            {
                if (pet.weight <= MaxWeight)
                {
                    Console.WriteLine("Mananca " + pet.Name);
                    petsEat += 1;
                }
            }

            if (petsEat == 0)
            {
                Console.WriteLine("Croc eat owner");
            }
        }

    }
}
