using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostCampOOP
{
    internal class Person
    {
        public readonly string name;
        public readonly string surname;
        public Role Role { get; set; }
        
        public Person(string _name, string _surname, Role role)
        {
            this.name = _name;            
            surname = _surname;
            Role = role;
        }


        
        //public Person(string _name, string _surname, int _age)
        //{
        //    name = _name;
        //    surname = _surname;
        //    age = _age;
        //}

        //public static string name= "value";// private
        
        



    }
}
