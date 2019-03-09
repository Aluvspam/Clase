using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Student : Person
    {
        public List<Class> Blacklog;
        public int Year;
        public Dictionary<Class, int> Grades;
        private double medie;

        public double MedieProp
        {
            get
            {
                int sum = 0, nr = 0;

                foreach (var nota in Grades)
                {
                    sum = sum + nota.Value * nota.Key.Points;
                    nr = nr + nota.Key.Points;
                }
                medie = (double)sum / nr;
                return this.medie;
            }
        }

        public Student(Gender gender, string name, Address address, string phoneNumber, Car car, int age, List<Animal> animals, bool smokes, List<Class> blacklog, int year, Dictionary<Class, int> grades) : base(gender, name, address, phoneNumber, car, age, animals, smokes)
        {
            this.Blacklog = blacklog;
            this.Year = year;
            this.Grades = grades;
        }

        public double Media()
        {
            int sum = 0, nr = 0;

            foreach (var note in Grades)
            {
                sum = sum + note.Value;
                nr++;
            }

            return (double)sum / nr;
        }

        public double MediaPonderata()
        {
            int sum = 0, nr = 0;

            foreach (var nota in Grades)
            {
                sum = sum + nota.Value * nota.Key.Points;
                nr = nr + nota.Key.Points;
            }

            return (double)sum / nr;
        }
    }
}
