using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class ShapeMath
    {
        //Reminder : static means we dont need creating an object in order to call function 
        public static double GetArea(string shape = "", double length1 = 0, double length2 = 0)
        {
            if(String.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            } 

            else if (String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * (length2/2);
            } 

            else if (String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                //Pow used for returning number raised to typed power
                return 3.14159 * Math.Pow(length1, 2);
            }
            
            else
            {
                return -1;
            }
        }       
    }
}
