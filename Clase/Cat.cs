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

        public Cat() : base()
        {
            this.name = "";
            this.Colour = 0;
        }
    }
}
