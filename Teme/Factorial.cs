using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teme
{
   public class Factorial
    {
       public double Factorial1(int n)
        {
            if (n == 0)
                return 1;
            double result = n * Factorial1(n - 1);
            return result;

        }
    }
}
