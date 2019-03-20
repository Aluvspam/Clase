using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
            new Exercitii().GradinaZoologica();
            var fierari = new Car("", "", null, 0);
            AfisareMasini(new Car[] { fierari });
            fierari.Colour = Colour.Red;
            fierari.Make = "fierari";
            fierari.Model = "F40";
            var oltcit = new Car("Oltcit", "", null, Colour.White);
            Car[] masini = new Car[] { fierari, oltcit, new Car("mergedes", "GLX", new Engine(Fuel.Diesel, 184, 2500, "AMG", 0), Colour.Silver) };
            AfisareMasini(masini);
            oltcit.Paint(Colour.Silver);
            AfisareMasini(masini);
            var translator = new Translator();
            var n = 7;
            Console.WriteLine("numarul este " + n);
            string sn = translator.RomanianNumber(n);
            Console.WriteLine("in romana este " + sn);
            sn = translator.DictionarRoEng(sn);
            Console.WriteLine(sn);
            sn = translator.TransformIntToString(n);
            Console.WriteLine(sn);
            sn = translator.Convert(n);
            Console.WriteLine("romana metoda Dianei2 " + sn);
            Class o1 = new Class();
            o1.Name = "Intermediari";
            o1.Points = 3;
            o1.Teacher = new Teacher() { Car = masini[2] };
            Gender o2 = Gender.female;
            Fuel o3 = Fuel.Electric;
            o1.Teacher.Gender = o2;
            masini[2].Engine.Fuel = o3;
            Student s1 = new Student(Gender.male, "", null, "", null, 0, null, false, null, 0, null);
            s1.Name = "Nume Student";
            s1.Blacklog = new List<Class>();
            s1.Blacklog.Add(new Class() { Name = "materia 1", Points = 5 });
            s1.Blacklog.Add(new Class() { Name = "materia 2" });

            s1.Gender = Gender.female;
            s1.Address = new Address() { Town = "Bucuresti", Street = "Splai", Nr = 290 };
            s1.PhoneNumber = "0721000122";
            s1.Year = 3;
            s1.Grades = new Dictionary<Class, int>();
            s1.Grades.Add(new Class() { Name = "materia 3", Points = 5 }, 10);
            s1.Grades.Add(new Class() { Name = "materia 4", Points = 10 }, 5);
            s1.Car = masini[0];
            Console.WriteLine(s1.Name + " gen: " + s1.Gender + " phone " + s1.PhoneNumber + " an " + s1.Year);
            Console.WriteLine("Adresa: " + s1.Address.Town + " " + s1.Address.Street + " " + s1.Address.Nr);
            Console.Write("Restante: ");
            foreach (var r in s1.Blacklog)
            {
                Console.WriteLine(r.Name + " " + r.Points);
            }
            Console.WriteLine();

            foreach (var item in s1.Grades)
            {
                Console.WriteLine(item.Key.Name + " " + item.Key.Points + " " + item.Value);
            }
            Dog dog = new Dog("Patrocle", 50, 55, 6);

            dog.GrowOlder();

            Console.WriteLine(dog.Age);

            Person person = new Person(Gender.male, "Femele", null, "", null, 0, null, false);
            //person.AdoptPet(dog);

            Dog dog2 = new Dog("Patrocle2", 50, 55, 6);
            Console.WriteLine("Patrocle2: " + dog2.Id);
            //Console.WriteLine(person.Pets.Count);
            Employee Andrei = new Employee();
            Andrei.Department = "HR";
            Andrei.Position = "Schef";
            Andrei.Skil = "";
            Andrei.Name = "Andrei";
            Andrei.WriteEmployee();
            Croc Croky = new Croc();
            Croky.Feed();
            Croky.GrowOlder();
            Croky.Move();
            Croky.Talk();
            */
            Cat pisicuta = new Cat();
            pisicuta.EatAnimal();

            Console.ReadKey();
        }
        static void AfisareMasini(Car[] masini)
        {
            foreach (var masina in masini)
            {
                Console.WriteLine("masina " + masina.Make + " " + masina.Model + " cu ID " + masina.Id + " are culoarea " + masina.Colour);
            }
        }
    }
}
