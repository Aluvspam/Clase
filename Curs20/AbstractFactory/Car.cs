using System.Collections.Generic;

namespace Curs20.AbstractFactory
{
    public class Car
    {
        private AbstractWheels wheels;
        private AbstractEngine engine;

        private List<Option> options;

        internal AbstractEngine Engine
        {
            get
            {
                return engine;
            }
            set
            {
                engine = value;
            }
        }
        internal AbstractWheels Wheels { get => wheels; set => wheels = value; }

        public void AddOption(Option option)
        {
            if (options == null)
            {
                options = new List<Option>();
            }

            options.Add(option);
        }
    }
}
