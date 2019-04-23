using System;
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

    }
    public interface Ijuice : IDrink
    {
        Ijuice Component
        {
            get; set;
        }

    }
    public interface ICocktail : IDrink, Ijuice
    {
        int TotalCost(int quantity, int cost);
    }

    public class Gin : IDrink
    {
        private int cost = 2;
        private int quantity = 25;

        public int GetCost()
        {
            return cost;
        }
        public int GetQuantity()
        {
            return quantity;
        }
    }

    public class Vodka : IDrink
    {
        private int cost = 3;
        private int quantity = 25;


        public int GetCost()
        {
            return cost;
        }
        public int GetQuantity()
        {
            return quantity;
        }
    }

    public class JB : IDrink
    {
        private int cost = 2;
        private int quantity = 25;


        public int GetCost()
        {
            return cost;
        }
        public int GetQuantity()
        {
            return quantity;
        }
    }

    public class Rom : IDrink
    {
        private int cost = 3;
        private int quantity = 25;

        public int GetCost()
        {
            return cost;
        }
        public int GetQuantity()
        {
            return quantity;
        }
    }

    public class Tonic : Ijuice
    {
        private int cost = 3;
        private int quantity = 25;

        public Ijuice Component { get; set; }

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
    public class Cola : Ijuice
    {
        private int cost = 3;
        private int quantity = 25;

        public Ijuice Component { get; set; }

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

    public class Orange : Ijuice
    {
        private int cost = 3;
        private int quantity = 25;

        public Ijuice Component { get; set; }

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

    public class Cranberry : Ijuice
    {
        private int cost = 3;
        private int quantity = 25;

        public Ijuice Component { get; set; }

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



