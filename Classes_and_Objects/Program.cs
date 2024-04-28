﻿namespace Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1;
            rect1.length= 200;
            rect1.width= 50;
            Console.WriteLine("Area of rect1 : {0}", rect1.Area());
            
            Rectangle rect2 = new Rectangle(100, 40);
            rect2 = rect1;
            rect1.length = 33;
            Console.WriteLine("Rect2.length : {0}", rect2.length);


            Animal fox = new Animal()
            {
                name = "Red",
                sound = "Raaw"
            };

            Console.WriteLine("# of Animals : {0}", Animal.GetNumAnimals());

            Console.WriteLine("Area of Rectangle : {0}", ShapeMath.GetArea("rectangle", 5, 6));

            //Creating a null 
            int? randNum = null;

            //Checking for null
            if (randNum == null)
            {
                Console.WriteLine("randNum is null");
            }
            if (!randNum.HasValue)
            {
                Console.WriteLine("randNum is null");
            }
        }

        // Struct, basically, is user defined type
        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l = 1, double w = 1) { length = l; width = w; }
            public double Area()
            {
                return length * width;
            }
        }
    }
}