using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1 
{
    public static class Triangle2Neha
    {
        public static string ValidTriangle( int firstAngle, int secondAngle, int thirdAngle) 
        {
            string result;
            if (firstAngle + secondAngle > thirdAngle^ secondAngle + thirdAngle > firstAngle && firstAngle + secondAngle + thirdAngle == 180) //made condition change so that all angles are different 
            {
                result = "The triangle is valid.";  
            }
            else
            {
                result = "The triangle is NOT valid."; 
            }
            return result;
        }
    }
   

} 
