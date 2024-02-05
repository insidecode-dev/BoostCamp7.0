using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostCampOOP
{
    internal class Person
    {
        static Person()
        {
            Console.WriteLine("static");     
        }
        public Person()
        {
            Console.WriteLine("normal");
        }

        //public Person(string _name, string _surname, int _age)
        //{
        //    name = _name;
        //    surname = _surname;
        //    age = _age;
        //}

        public static string name= "value";// private
        public  string surname ;
        public int age;
        



    }
}
