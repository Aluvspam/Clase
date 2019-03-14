using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
   abstract class HunterAnimal : Animal
    {
        protected float MAX_Weight_Prey;

        public virtual void EatAnimal()
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
    }
}
