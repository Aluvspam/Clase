using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Person
    {
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

        public void AdoptPet(Animal newPet)
        {
            Pets.Add(newPet);
        }
    }
}
