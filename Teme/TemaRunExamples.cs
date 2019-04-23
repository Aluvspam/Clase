using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs15.Decorator.Tema
{
    public class TemaRunExamples
    {
        public static void Run()
        {
            IDrink drink = new Drink();

            Ijuice orange = new Orange();
            orange.Component = gin;
            
        }
    }
}
