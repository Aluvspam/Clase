using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoStrategy
{
    public abstract class AbstractEntity
    {
        protected string name;
        public virtual void Move()
        {
            Console.Write("I'm a {0}", name);
        }
    }
}
