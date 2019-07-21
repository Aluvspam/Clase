using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class Singleton
    {
        static Singleton instance;
        static object lacat = new object();
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lacat)
                    {
                        if (instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }
    }
}
