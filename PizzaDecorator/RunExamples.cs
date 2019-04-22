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

            AbstractTopping topping1 = new Mozzarella2();
            topping1.Component = p;

            AbstractTopping topping2 = new Salami();
            topping2.Component = topping1;

            Console.WriteLine("Your pizza costs: " + topping2.GetCost());
        }
    }
}
