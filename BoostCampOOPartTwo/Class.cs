using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BoostCampOOPartTwo
{
    public class Person:IPerson, ICard // inherited class or base class or parent class
    {
      
        
        // encapsulation
        //private int age;

        //public int Age 
        //{ 
        //    get 
        //    { 
        //        return age; 
        //    } 

        //    set 
        //    {
        //      if (value<0) { age = 0;}
        //      else age = value;
        //    } 
        //}

        // inheritance
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        
        // does not have body

        public void WriteSomething()
        {
            Console.WriteLine("something");
        }

        public virtual int CalculateSalary()
        {
            return 800;
        }

        public void ShowCard()
        {
            throw new NotImplementedException();
        }

        public void ShowID()
        {
            Console.WriteLine("this is ID of person");
        }

        public void ShowWorkPlace()
        {
            throw new NotImplementedException();
        }


        // these nelong to card interface
        public void PayByCard()
        {
            Console.WriteLine("paid by card");
        }

        public void ShowBalance()
        {
            Console.WriteLine("Your balance is : ${0}", 24);
        }

       
    }

    public class Doctor:Person // derived class or child classs
    {
        public Doctor() { }

       
        public string Cetrificate { get; set; }

        public string GetInfo()
        {
            return $"{Name} {Surname} {Age}";
        }

        public  void PrintName()
        {
            Console.WriteLine($"Doctor data : {Name}{Surname}");
        }

        public override int CalculateSalary()
        {
            Console.Write("salary of doctor :");
            return 1000;
        }
    }

    public class Developer:Person //
    {
        public Developer()
        {
                
        }
      
        public string ProgLang { get; set; }

        //public override void PrintName()
        //{
        //    Console.WriteLine($"Developer data : {ProgLang}");
        //}

        public override int CalculateSalary()
        {

            return 4000;
        }
    }
    public class Teacher : Person
    {
        
        public string Subject { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"Teacher data : {Subject}");
        }

     
    }
}
    

