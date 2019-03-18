using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Swan : HunterAnimal
    {
        public string colour;
        public int Food;


        public Swan(int food, int age, int energy, int health) : base()
        {
            this.Food = food;
            this.age = age;
            this.energy = energy;
            this.health = health;
        }
        public override void Feed()
        {
            if (Food < 1)
            {
                energy--;
                health--;
            }
            else
                energy += 1;
        }

        public override void GrowOlder()
        {
            age++;
        }

        public override void Move()
        {
            energy--;
        }

        public override void Talk()
        {
            Console.WriteLine("$@$@$@$@$@");
        }
    }
}
