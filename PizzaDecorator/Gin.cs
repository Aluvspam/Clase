using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Gin : AbstractDrink
    {
        public Gin()
        {
            StartDrink();
        }

        private void StartDrink()
        {
            volume = 25;
            price = 2;
        }
    }
}
