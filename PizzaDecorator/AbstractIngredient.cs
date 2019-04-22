using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class AbstractIngredient : AbstractDrink //decorator
    {
        public AbstractIngredient()
        {
            MixDrink();
        }

        public abstract void MixDrink();
    }
}
