using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs15.Decorator
{
    public class Shrooms : ITopping
    {
        public IPizza Component { get; set; }
        private int cost = 3;
        public int GetCost()
        {
            if (Component != null)
            {
                return Component.GetCost() + cost;
            }
            else
            {
                return cost;
            }
        }
    }
}
