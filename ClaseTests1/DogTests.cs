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
            //var owner = new Person(Gender.male, "Andrei", null, "+40112", null, 34, new List<Animal>(), true);
            //owner.AdoptPet(dog);

            dog.Feed();
            //if(dog.Owner.eggs > 0)
            //{
            //    Assert.AreEqual(dog.Owner.eggs, 0);
            //}
            Assert.AreEqual(dog.Energy, 110);
        }

        [TestMethod()]
        public void FeedTestIf()
        {
            Dog dog = new Dog("Patrocle", 80, 85, 3);
            var owner = new Person(Gender.male, "Andrei", null, "+40112", null, 34, new List<Animal>(), true);
            owner.AdoptPet(dog);
            dog.weight = 5;
            Lion lion = new Lion();
            lion.weight = 1;
            owner.AdoptPet(lion);

            //owner.eggs = 100;
            dog.Feed();
            if (owner.eggs > 0)
            {
                Assert.AreEqual(dog.owner.eggs, 0);
            }
            else
            {
                Assert.AreEqual(dog.owner.eggs, 0);
            }

            Assert.AreEqual(dog.Energy, 110);
        }
    }
}