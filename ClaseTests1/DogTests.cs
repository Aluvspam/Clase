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
    public class DogTests
    {
        [TestMethod()]
        public void EatAnimalTest()
        {
            Dog dog = new Dog("Patrocle", 80, 85, 3);
            dog.EatAnimal();
            Assert.AreEqual(dog.Health, 81);
            Assert.AreEqual(dog.Energy, 86);
        }

        [TestMethod()]
        public void GrowOlderTest()
        {
            Dog dog = new Dog("Patrocle", 80, 85, 3);
            dog.GrowOlder();

            Assert.AreEqual(dog.Age, 4);
        }

        [TestMethod()]
        public void FeedTest()
        {
            Dog dog = new Dog("Patrocle", 80, 85, 3);
            dog.Feed();
            //if(dog.Owner.eggs > 0)
            //{
            //    Assert.AreEqual(dog.Owner.eggs, 0);
            //}
            Assert.AreEqual(dog.Energy, 110);
        }
    }
}