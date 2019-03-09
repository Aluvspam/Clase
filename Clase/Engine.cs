using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Engine
    {
        public Fuel Fuel;
        public int HorsePower { get; set; }
        public int Capacity { get; set; }
        public string Make { get; set; }
        public string Id { get; set; }
        public CombustionType CombustionType;
        public static int IdC = 0;

        public Engine(Fuel fuel, int horsepower, int capacity, string make, CombustionType combustionType)
        {
            this.Fuel = fuel;
            this.HorsePower = horsepower;
            this.Capacity = capacity;
            this.Make = Make;
            this.CombustionType = combustionType;
            this.Id = IdC.ToString();
            IdC = IdC + 1;

        }
    }
}
