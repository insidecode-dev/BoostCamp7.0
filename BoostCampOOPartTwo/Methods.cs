using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostCampOOPartTwo
{
    internal class Methods
    {
        public Person ReturnPerson(string name, string surname, int age)
        {
            Person person = new Person() { 
             Name = name,
             Surname = surname,
             Age = age
            };

            return person;
        }



        // task
        public void ShowPersonData(Person person)
        {
            Console.WriteLine("Name : {0}\nSurname : {1}\nAge : {2}", person.Name, person.Surname, person.Age);
        }
    }
}
