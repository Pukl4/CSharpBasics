using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerator
{
    class Box
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Breadth { get; set; }

        public Box()
            : this(1, 1, 1) { }


        public Box(double length, double width, double breadth)
        {
            Length = length;
            Width = width;
            Breadth = breadth;
        }


        //You can overload +, -, *. /, %, !, ==, !=, >, <, ++, --, >=, <=
        public static Box operator +(Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length + box2.Length,
                Width = box1.Width + box2.Width,
                Breadth = box1.Breadth + box2.Breadth
            };
            return box;
        }

        public static Box operator -(Box box1, Box box2)
        {
            Box box = new Box()
            {
                Length = box1.Length - box2.Length,
                Width = box1.Width - box2.Width,
                Breadth = box1.Breadth - box2.Breadth
            };
            return box;
        }
        public static bool operator ==(Box box1, Box box2)
        {
            if ((box1.Length == box2.Length) &&
                (box1.Width == box2.Width) &&
                (box1.Breadth == box2.Breadth))
                {
                    return true;
                }
                return false;
        }

        public static bool operator !=(Box box1, Box box2)
        {
            if ((box1.Length != box2.Length) ||
                (box1.Width != box2.Width) ||
                (box1.Breadth != box2.Breadth))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format("Box with height : {0} Width : {1} Breadth : {2}", Length, Width, Breadth);
        }

        public static explicit operator int(Box b) 
        {
            return (int)(b.Length + b.Width + b.Breadth) / 3;
        }

        public static implicit operator Box(int i)
        {
            return new Box(i, i, i);
        }
    }
}
