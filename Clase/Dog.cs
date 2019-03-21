using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    // Dog dog = new Dog("abcd", 70, 25, 20);
    // dog.Feed();
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

        public int Energy
        {
            get
            {
                return energy;
            }
            set
            {
                energy = value;
            }

        }

        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public Dog(string name, int health, int energy, int age, double fat)
        {
            this.name = name;
            this.health = health;
            this.energy = energy;
            this.age = age;
            this.fat = fat;
        }

        public override void Feed() 
        {
            this.fat += 10;
            if (this.owner != null)
            {
                this.energy += 25;
                if (this.owner.eggs > 0)
                {
                    Console.WriteLine("Eaten eggs");
                    this.owner.eggs = 0;
                }
                else
                {
                    var pets = this.owner.Pets;

                    foreach (var pet in pets)
                    {
                        if (pet.weight <= maxWeight && this!= pet)
                        {
                            Console.WriteLine("Eat " + pet.Name);   
                        }
                    }
                }
            }
            else
            {
                this.energy += 25;
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
            if (eggs > 0)
            {
                Console.WriteLine($"Eaten eggs: {eggs}");
            }
            else
            {
                Console.WriteLine("Master has no eggs");
            }
            if (owner != null)
            {
                owner.Pets.Remove(this);
            }
        }

        public void PrintPreyMaxWeight()
        {
            Console.WriteLine(maxWeight);
        }
        public override void EatAnimal()
        {
            this.energy += 1;
            this.health += 1;
        }
    }
}
