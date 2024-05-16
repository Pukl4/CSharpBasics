using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{
    abstract class Shape
    {
        public string Name { get; set; }

        //Virtual class is a class that serves as a base for other classes and can be overridden by derived classes
        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }
        public abstract double Area();

    }
}
