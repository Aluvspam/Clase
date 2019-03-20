using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public abstract class HunterAnimal : Animal
    {
        protected float PreyMaxWeight { get; set; }

        public virtual void EatAnimal()
        {
            if (this.owner != null)
            {
                var pets = this.owner.Pets;

                foreach (var pet in pets)
                {
                    if (pet.weight <= PreyMaxWeight)
                    {
                        Console.WriteLine("Eat " + pet.Name);
                        pets.Remove(pet);
                    }
                }
            }
        }
    }
}
