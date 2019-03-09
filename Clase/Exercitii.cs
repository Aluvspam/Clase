using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Exercitii
    {
        public void GradinaZoologica()
        {
            Dog dog = new Dog("Patrocle", 50, 55, 6);
            Employee zooKeeper = new Employee(/*Gender.male, "Femele", null, "", null, 0, null, false*/);
            zooKeeper.AdoptPet(dog);
            Dog dog2 = new Dog("Patrocle2", 50, 55, 6);
            zooKeeper.AdoptPet(dog2);
            Croc Croky = new Croc();
            Console.WriteLine("Croky status");
            Croky.ShowStatus();
            Croky.Swim();
            Console.WriteLine("Croky status after swimming");
            Croky.ShowStatus();
            Croky.Feed();
            Croky.GrowOlder();
            Croky.Move();
            Croky.Talk();
            zooKeeper.AdoptPet(Croky);
            zooKeeper.AdoptPet(new Cat() { Colour = Colour.Black });
            zooKeeper.AdoptPet(new Lion());
            zooKeeper.AdoptPet(new Chicken());
            zooKeeper.AdoptPet(new Swan(0, 0, 0, 0));
            zooKeeper.AdoptPet(new Cioara("Ciordeles", 50, 1, (int)(Math.Pow(Math.E, Math.PI))));
            foreach (var pet in zooKeeper.Pets)
            {
                pet.Feed();
                pet.GrowOlder();
                pet.Move();
                pet.Talk();
                Console.WriteLine(pet.ToString());
            }
            Console.WriteLine("Croky status");
            Croky.ShowStatus();
            var crocky = zooKeeper.Pets[2];
            var crockyCroco = (Croc)crocky;
            Console.WriteLine("crockyCroco status");
            crockyCroco.ShowStatus();
            crockyCroco.Swim();
            Console.WriteLine("crockyCroco status after swimming");
            crockyCroco.ShowStatus();
            Console.WriteLine("Croky status after crockyCroco swimmed");
            Croky.ShowStatus();
            var Acroc = new Croc();
            Console.WriteLine("Acroc status");
            Acroc.ShowStatus();
            Acroc.Swim();
            Console.WriteLine("Acroc status after swimming");
            Acroc.ShowStatus();
            Console.WriteLine("Croky status after Acroc swimmed");
            Croky.ShowStatus();
            //var cutuCroco = (Croc)zooKeeper.Pets[1];
            //cutuCroco.ShowStatus();
            //cutuCroco.Swim();
            Console.WriteLine(Math.Log10(12345));
            var logaritm = Math.Log(Math.E);
        }
    }
}
