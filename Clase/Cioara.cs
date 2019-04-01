using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Cioara : HunterAnimal
    {
        public Cioara(string name, int health, int energy, int age) : base()
        {
            this.name = name;
            this.health = health;
            this.energy = energy;
            this.age = age;

        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public int Health
        {
            get
            {
                return health;
            }
        }

        public int Energy
        {
            get
            {
                return energy;
            }
        }

        public override void Feed()
        {
            this.energy += 44;

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
            Console.WriteLine("haur,fer");
        }
        public override void EatAnimal()
        {
            this.energy += 1;
            this.health += 1;
        }
    }
}
