﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{

    public class Cat : HunterAnimal
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
            //   Console.WriteLine("GrowOlder");
            age++;
            weight *= .85;
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
            Console.WriteLine("Move");
        }

        public override void Talk()
        {
            Console.WriteLine("Talk");
        }

        public Cat() : base()
        {
            this.name = "";
            this.Colour = 0;
        }



        //public Cat() : base()
        //{
        //    this.name = "";
        //   this.Colour = 0;

        //}
    }
}
