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
    public class TonicTests
    {
        [TestMethod()]
        public void GetNameTest()
        {
            IDrink gin = new Gin();
            IJuice tonic = new Tonic { Component = gin };
            Assert.AreEqual(gin.GetName() + ' ' + new Tonic().GetName(), tonic.GetName());
        }
    }
}