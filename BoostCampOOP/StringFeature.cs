using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoostCampOOP
{
    internal static class StringFeature
    {
        public static bool IsLowerThanFour(this string a/*, string num1, string num2, string operationType*/)
        {
            if ( a.Length<4 ) 
                return true;
            return false;
        } 

        public static bool IsHigherThanThis( int a, int b)
        {
            if (a > b)
                return true;
            return false;
        }
    }
}
