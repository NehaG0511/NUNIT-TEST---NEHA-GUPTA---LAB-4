using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1 
{
    public static class Triangle3 
    {
        public static string ValidTriangle(double firstAngle, double secondAngle, double
        thirdAngle) 
        {
            string result;                         //changing my conditions for prooving triangle validation - IN PROGRESS
            if ((firstAngle > 0 && secondAngle >0 && thirdAngle > 0 && (firstAngle + secondAngle + thirdAngle == 180)))
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
