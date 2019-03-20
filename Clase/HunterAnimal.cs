using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public abstract class HunterAnimal : Animal
    {
        public int PreyMaxWeight { get; set; }

        public virtual void EatAnimal()
        {

        }
    }
}
