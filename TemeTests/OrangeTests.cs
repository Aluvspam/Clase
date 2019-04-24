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
    public class OrangeTests
    {
        [TestMethod()]
        public void GetQuantityTest()
        {
            IDrink gin = new Gin();
            IJuice orange = new Orange { Component = gin };
            Assert.AreEqual(gin.GetQuantity() + (new Orange()).GetQuantity(), orange.GetQuantity());
        }
    }
}