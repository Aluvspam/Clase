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
    public class CrocTests
    {
        [TestMethod()]
        public void GrowOlderTest()
        {
            var owner = new Person(Gender.male, "Andrei", null, "+40112", null, 34, new List<Animal>(), true);
            var Bismark = new Croc("Bismark");
            Bismark.weight = 1114;
            owner.AdoptPet(Bismark);
            //Console.WriteLine(Bismark.ToString());
            //Console.WriteLine("Bismark grows older");
            Bismark.GrowOlder();
            //Console.WriteLine(Bismark.ToString());
            Assert.AreEqual(1114 * .99, Bismark.weight);
            Assert.AreEqual(true, Bismark.ItsAlive);
            //Assert.AreEqual(1, Bismark);
            //Assert.AreEqual(90,Bismark.)
            for (int i = 0; i < 20; i++)
            {
                Bismark.GrowOlder();
            }
            Assert.AreEqual(false, Bismark.ItsAlive);
        }
    }
}