using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Lab.Models
{
    public class Maths
    {
        
        public static string Add(int num1, int num2)
        {
            int result = (num1 + num2);
            return result.ToString();
            
        }

        public static string Divide(int num1, int num2)
        {
            double divisionOfNum = num1 / num2;
            double remainder = num1 % num2;

            return $"{num1} / {num2} =  {divisionOfNum} Remainder: {remainder}";
        }
    }
}
