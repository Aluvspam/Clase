using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoStrategy
{
    public class Dog : AbstractEntity
    {
        public Dog()
        {
            name = "dog";
        }
        public override void Move()
        {
            base.Move();
            Console.WriteLine("I run fast on all my 4 feet");
        }
    }
}
