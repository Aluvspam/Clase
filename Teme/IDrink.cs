﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs15.Decorator.Tema
{
    public interface IDrink
    {
        int GetCost();
        int GetQuantity();
        string GetName();

    }
    public interface IJuice : IDrink
    {
        IDrink Component
        {
            get; set;
        }

    }
    public interface ICocktail : IDrink, IJuice
    {
        int TotalCost(int quantity, int cost,string name);
    }

    public class Gin : IDrink
    {
        private int cost = 2;
        private int quantity = 25;
        private string name = "Gin";

        public int GetCost()
        {
            return cost;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public string GetName()
        {
            return name;
        }
    }

    public class Vodka : IDrink
    {
        private int cost = 3;
        private int quantity = 25;
        private string vodka = "Vodka";

        public int GetCost()
        {
            return cost;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public string GetName()
        {
            return vodka;
        }
                
    }

    public class JB : IDrink
    {
        private int cost = 2;
        private int quantity = 25;
        public string jb = "Whiskey";


        public int GetCost()
        {
            return cost;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public string GetName()
        {
            return jb;
        }
    }

    public class Rom : IDrink
    {
        private int cost = 3;
        private int quantity = 25;
        private string name = "Rom";
        public int GetCost()
        {
            return cost;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public string GetName()
        {
            return name;
        }
    }

    public class Tonic : IJuice
    {
        private int cost = 3;
        private int quantity = 25;
        public string tonic = "Tonic";

        public IDrink Component { get; set; }

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
        public int GetQuantity()
        {
            return quantity;
        }
        public string GetName()
        {
            return tonic;
        }
    }
    public class Cola : IJuice
    {
        private int cost = 3;
        private int quantity = 25;
        public string cola = "Cola";

        public IDrink Component { get; set; }

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
        public int GetQuantity()
        {
            return quantity;
        }

        public string GetName()
        {
            return cola;
        }
    }

    public class Orange : IJuice
    {
        private int cost = 3;
        private int quantity = 25;

        public IDrink Component { get; set; }

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
        public int GetQuantity()
        {
            return quantity;
        }
    }

    public class Cranberry : IJuice
    {
        private int cost = 3;
        private int quantity = 25;

        public IDrink Component { get; set; }

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
        public int GetQuantity()
        {
            return quantity;
        }
    }
}



