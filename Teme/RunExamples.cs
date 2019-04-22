using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs15.Decorator
{
    public class RunExamples
    {
        public static void Run()
        {
            IPizza p = new Pizza();

            //AbstractTopping topping1 = new Mozzarella2();
            //topping1.Component = p;

            //AbstractTopping topping2 = new Salami();
            //topping2.Component = topping1;
            ITopping topping1 = new Mozzarella();
            topping1.Component = p;
            ITopping topping2 = new Peperoni();
            topping2.Component = topping1;
            ITopping topping3 = new Shrooms();
            topping3.Component = topping2;
            Mozzarella extraBranza = new Mozzarella();
            extraBranza.Component = topping3;
            Console.WriteLine("Your pizza costs: " + extraBranza.GetCost());
        }
    }
}
