using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Tests
{
    [TestClass()]
    public class CioaraTests
    {
        [TestMethod()]
        public void EatAnimalTest()
        {
            Cioara cioara = new Cioara("Ciordeles", 80, 85, 18);
            cioara.EatAnimal();

            Assert.AreEqual(cioara.Health, 81);
        }

        [TestMethod()]
        public void GrowOlderTest()
        {
            Cioara cioara = new Cioara("Ciordeles", 80, 85, 18);
            cioara.GrowOlder();
            Assert.AreEqual(cioara.Age, 19);
        }

        [TestMethod()]
        public void FeedTest()
        {
            Cioara cioara = new Cioara("Ciordeles", 80, 85, 18);
            cioara.Feed();
            Assert.AreEqual(cioara.Energy,129);
        }
    }
}