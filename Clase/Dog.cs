using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    //TO DO: Diana create a method to eat eggs if master has eggs
    //Add a constant to tell us the max weight of a prey
    public class Dog : HunterAnimal
    {
        private const int maxWeight = 15;
        
        public int Age
        {
            get
            {
                return age;
            }
        }

        public Dog(string name, int health, int energy, int age)
        {
            this.name = name;
            this.health = health;
            this.energy = energy;
            this.age = age;
        }

        public override void Feed()
        {
            this.energy += 25;
            if(this.owner.eggs > 0)
            {
                Console.WriteLine("Eaten eggs");
                this.owner.eggs = 0;
            }
            else
            {
                var pets = this.owner.Pets;

                foreach (var pet in pets)
                {
                    if (pet.weight <= maxWeight)
                    {
                        Console.WriteLine("Eat " + pet.Name);
                        pets.Remove(pet);
                    }
                }
            } 


        }

        public override void GrowOlder()
        {
            this.age++;
        }

        public override void Move()
        {
            this.health += 10;
        }

        public override void Talk()
        {
            Console.WriteLine("ham ham");
        }

        public void EatEggs(int eggs)
        {
            if(eggs > 0)
            {
                Console.WriteLine($"Eaten eggs: {eggs}");
            }
            else
            {
                Console.WriteLine("Master has no eggs");
            }
        }

        public void PrintPreyMaxWeight()
        {
            Console.WriteLine(maxWeight);
        }
    }
}
