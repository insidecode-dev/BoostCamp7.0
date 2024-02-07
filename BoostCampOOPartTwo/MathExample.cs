using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostCampOOPartTwo
{
    public class MathExample
    {
        public int Calculate()
        {
            return 5;
        }

        public int Calculate(int a, int b)
        {            
            return a+b;
        }

        public int Calculate(int a, int b, string operationType)
        {
            if (operationType=="+")
            
                return a + b;
            
            return a - b;
        }

    }
}
