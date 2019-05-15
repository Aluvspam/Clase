using System;

namespace DoFactory.GangOfFour.Factory.RealWorld
{
    /// <summary>
    /// Factory Method Design Pattern.
    /// </summary>
    public abstract class PizzaStore
    {
        public Pizza OrderPiza() {

            // this is the Factory Method 
            // allows the subclass to choose the concreate object class to instantiate
            var pizza = CreatePizza();
            
            return pizza;
        }

        public abstract Pizza CreatePizza();
    }

    public class PizzaOneStore : PizzaStore
    {
        

        public override Pizza CreatePizza()
        {
            return new PizzaOne();
        }
    }

    public class PizzaTwoStore : PizzaStore
    {


        public override Pizza CreatePizza()
        {
            return new PizzaTwo();
        }
    }

    public abstract class Pizza
    {
    }

}