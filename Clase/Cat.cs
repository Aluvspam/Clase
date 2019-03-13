using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Cat : Animal
    {
        //TO DO: Teo to add code here (fields, variables, methods constructor(s)
        //add a method to eat other animals of the master if they are small enough
        //Add a constant to tell us the max weight of a prey

        private const float MAX_Weight_Prey = 5;

        public Colour Colour;

        public override void Feed()
        {
            Console.WriteLine("Feed");
        }

        public override void GrowOlder()
        {
            Console.WriteLine("GrowOlder");
        }

        public override void Move()
        {
            Console.WriteLine("Move");
        }

        public override void Talk()
        {
            Console.WriteLine("Talk");
        }
        
        public void EatAnimal()
        {
            if (this.owner != null)
            {
                var pets = this.owner.Pets;

                foreach (var pet in pets)
                {
                    if (pet.weight <= MAX_Weight_Prey)
                    {
                        Console.WriteLine("Eat " + pet.Name);
                        pets.Remove(pet);
                    }
                }
            }
        }

        public Cat() : base()
        {
            this.name = "";
            this.Colour = 0;
        }
    }
}
