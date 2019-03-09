using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    class Employee : Person
    {
        private double salary;
        private string Currency = "Ron";
        public string Department;
        public string Position;
        public string Skil;
        public void WriteEmployee()
        {
            Console.WriteLine($"Angajatu {Name} are salariul {this.salary} {this.Currency} pe luna");
        }


        public Employee() : base(Gender.male, "", null, "", null, 0, new List<Animal>(), false)
        {
            this.salary = 3200;
            this.Currency = "Oiro";
        }
    }
}
