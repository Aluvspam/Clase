using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public abstract class Animal
    {
        //TO DO: Gaby add a field to tell us the weight of an animal
        //and add a field to tell us the owner of the Animal. if null the Animal is wild
        //modificare nevoita
        public double weight;
        internal Person owner;
        static int count;
        public int Id
        {
            get
            {
                return id;
            }
        }
        int id;
        protected int health;
        protected int age;
        protected int energy;
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
        }

        public Animal()
        {
            id = count;
            count++;
        }
        public abstract void Talk();
        public abstract void Move();
        public abstract void Feed();
        public abstract void GrowOlder();

        public override string ToString()
        {
            var tip = GetType().ToString().Substring(6);
            return String.Format($"my name is {Name} and I am a {tip} and I am {age} years old. My weight is {weight}, I have {health} health and {energy} energy");
        }
    }
}
