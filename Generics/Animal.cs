using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Animal
    {
        public string Name { get; set; }
        public Animal(string name = "No name") {  Name = name; }
        //Generics can be used with different data types
        // <T> will be replaced with usable data type like <int> or <string>
        public static void GetSum<T>(ref T num1, ref T num2)
        {
            double dbl = Convert.ToDouble(num1);
            double dbl2 = Convert.ToDouble(num2);
            Console.WriteLine($"{dbl}+{dbl2}={dbl+dbl2}");
        }
    }
}
