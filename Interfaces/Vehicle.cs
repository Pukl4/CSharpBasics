using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Vehicle : IDrivable
    {
        public string Brand { get; set; }
        public Vehicle(string brand = "No brand", int wheels = 0, double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }
        public double Speed { get; set; }
        public int Wheels { get; set; }
        public void Move()
        {
            Console.WriteLine($"The {Brand} moves forward at {Speed} mph");
        }
        public void Stop()
        {
            Console.WriteLine($"The {Brand} Stops");
            Speed = 0;
        }
    }
}
