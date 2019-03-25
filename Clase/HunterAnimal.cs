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
        public int Energy
        {
            get
            {
                return energy;
            }
            protected set
            {
                energy = value;
            }
        }
        public bool Canibal;

        public virtual void EatAnimal()
        {
            List<Animal> mancate = new List<Animal>();

            if (this.owner != null)
            {
                var pets = this.owner.Pets;

                foreach (var pet in pets)
                {
                    if (pet.weight <= PreyMaxWeight)
                    {
                        if (pet.GetType() ==this.GetType() && this.Canibal == true)
                        {
                            mancate.Add(pet);
                        }
                        Console.WriteLine("Eat " + pet.Name);
                        //pets.Remove(pet);
                        mancate.Add(pet);
                    }
                }
                foreach(var mancat in mancate)
                {
                    pets.Remove(mancat);
                }
            }
        }

        //public HunterAnimal(float PreyMaxWeight) : base()
        public HunterAnimal() : base()

        {
            this.PreyMaxWeight = PreyMaxWeight;
        }
    }
}
