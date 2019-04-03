using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoStrategy
{
    public class Drone : AbstractEntity
    {
        public Drone()
        {
            name = "Drone";
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("I fly!");
        }
    }
}
