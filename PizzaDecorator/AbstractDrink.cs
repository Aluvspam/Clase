using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class AbstractDrink
    {
        protected int volume;
        protected int price;
        public int Volume
        {
            get { return volume; }
        }
        public int Price
        {
            get
            {
                return price;
            }
        }
    }
}
