﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs15.Decorator
{
    public class Peperoni : ITopping
    {
        private int cost = 8;

        public IPizza Component { get; set; }

        public int GetCost()
        {
            if (Component != null)
            {
                return cost + Component.GetCost();
            }
            else
            {
                return cost;
            }
        }
    }
}
