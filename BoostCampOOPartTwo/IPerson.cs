using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostCampOOPartTwo
{
    // 
    public interface IPerson
    {
       // public string str; interface does not contain field
       // interface does not contain constructor
        
        void ShowID();
        void ShowWorkPlace();       

        public void PrintName()
        {
            Console.WriteLine("name");
        }
    }
}
