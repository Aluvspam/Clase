using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Car
    {
        public string Make;
        public string Model;
        public string Id;
        public Engine Engine;
        public Colour Colour;
        public static int Count = 0;

        public Car(string Make, string model, Engine engine, Colour colour)
        {
            this.Make = Make;
            this.Model = model;
            this.Id = Count.ToString();
            Count = Count + 1;
            this.Engine = engine;
            this.Colour = colour;
        }
        public Car()
        {
            Id = Count.ToString();
            Count++;
        }

        public void Paint(Colour c)
        {
            this.Colour = c;
        }
    }
}
