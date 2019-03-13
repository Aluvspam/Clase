using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Person
    {
        //TO DO: Teo add a field to tell us how many eggs a person has
        //and create a method to buy eggs from another Person
        //and add a field wallet to count the money a person has
        public int eggs;
        public long wallet;
        private const long PRICE = 5;

        public Gender Gender { get; set; }
        public string Name { get; set; }
        public Address Address;
        public string PhoneNumber { get; set; }
        public Car Car;
        public int Age;
        public List<Animal> Pets;
        private bool smokes;

        public Person(Gender gender, string name, Address address, string phoneNumber, Car car, int age, List<Animal> animals, bool smokes)
        {
            this.Gender = gender;
            this.Name = name;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Car = car;
            this.Age = age;
            this.Pets = animals;
            this.smokes = smokes;
        }

        public void BuyEggs(Person person, int eggs)
        {
            this.eggs = this.eggs + eggs;
            person.eggs = person.eggs - eggs;
            wallet = wallet - eggs * PRICE;
            person.wallet = person.wallet + eggs * PRICE;
        }


        public void AdoptPet(Animal newPet)
        {
            Pets.Add(newPet);
            newPet.owner = this;
        }
    }
}
