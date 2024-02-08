using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostCampOOPartTwo
{
    public class WorkerClass : IPerson
    {
        public void ShowID()
        {
            Console.WriteLine("this is ID of workerclass");
        }

        public void ShowWorkPlace()
        {
            throw new NotImplementedException();
        }
    }
}
