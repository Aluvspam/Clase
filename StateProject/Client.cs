using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateProject
{
    public class Client
    {
        public static void Run()
        {
            var context = new Context();
            context.setState(new StateOne());
            context.GoNext();
        }
    }
}
