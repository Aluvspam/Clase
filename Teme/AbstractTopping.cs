using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs15.Decorator
{
    public class AbstractTopping : IPizza
    {
        protected int cost = 0;

        public IPizza Component { get; set; }

        public virtual int GetCost()
        {
            if (Component != null)
            {
                return cost + Component.GetCost();
            }
            else
            {
                return cost;
            }
        }
    }

    public class Mozzarella2 : AbstractTopping
    {
        public Mozzarella2()
        {
            cost = 3;
        }
    }

    public class Salami : AbstractTopping
    {
        public Salami()
        {
            cost = 13;
        }
    }
}
