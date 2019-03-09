using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Teacher : Person
    {
        public string Experience;
        public Teacher() : base(Gender.male, "Femele", null, "", null, 0, null, false)
        {
            Experience = "multa";
        }
    }
}
