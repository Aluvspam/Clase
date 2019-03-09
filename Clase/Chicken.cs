using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Chicken : Animal
    {
        //TO DO: Liviu to add code here (fields, variables, methods constructor(s)
        public override void Feed()
        {
            string name = "Chicky";
            Console.WriteLine($"I like to eat other chickens i'm called {name}");
        }

        public override void GrowOlder()
        {
            int age = 4;
            Console.WriteLine(age);
        }

        public override void Move()
        {
            string movement = "peste tot";
            Console.WriteLine(movement);
        }

        public override void Talk()
        {
            var language = "Cotcodack!!!";
            Console.WriteLine(language);
        }

        public Chicken()
        {
            return;
        }
    }
}
