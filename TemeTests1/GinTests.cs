using Microsoft.VisualStudio.TestTools.UnitTesting;
using Curs15.Decorator.Tema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs15.Decorator.Tema.Tests
{
    [TestClass()]
    public class GinTests
    {
        [TestMethod()]
        public void GetCostTest()
        {
            IDrink gin = new Gin();
            IJuice orangeCost = new Orange();
            IJuice tonicCost = new Tonic();
            IJuice ginOrange = new Orange { Component = gin };
            IJuice ginTonic = new Tonic { Component = gin };
            Assert.AreEqual(orangeCost.GetCost()+ gin.GetCost(),ginOrange.GetCost());
            Assert.AreEqual(gin.GetCost() + tonicCost.GetCost(), ginTonic.GetCost());

        }

        [TestMethod()]
        public void GetQuantityTest()
        {
            IDrink gin = new Gin();
            IJuice orangeQnt = new Orange();
            IJuice tonicQnt = new Tonic();
            IJuice ginOrange = new Orange { Component = gin };
            IJuice ginTonic = new Tonic { Component = gin };
            Assert.AreEqual(orangeQnt.GetQuantity() + gin.GetQuantity(), ginOrange.GetLongDrinkQuantity());
            Assert.AreEqual(tonicQnt.GetQuantity() + gin.GetQuantity(), ginTonic.GetLongDrinkQuantity());
        }

        [TestMethod()]
        public void GetNameTest()
        {
            IDrink gin = new Gin();
            IJuice orangeName = new Orange();
            IJuice tonicName = new Tonic();
            IJuice ginOrange = new Orange { Component = gin };
            IJuice ginTonic = new Tonic { Component = gin };
            Assert.AreEqual(gin.GetName() + ' ' + orangeName.GetName(), ginOrange.GetName());
            Assert.AreEqual(gin.GetName() + ' ' + tonicName.GetName(), ginTonic.GetName());
        }
    }
}