using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs15.Decorator
{
    public interface IPizza
    {
        int GetCost();
    }

    public interface ITopping: IPizza
    {
        IPizza Component { get; set; }
    }

    public class Pizza : IPizza
    {
        private int cost = 10;

        public int GetCost()
        {
            return cost;
        }
    }

}
