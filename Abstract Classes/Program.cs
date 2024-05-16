namespace Abstract_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(5), new Rectangle(4, 5) };
            foreach (Shape s in shapes) 
            {
                s.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());

                Circle testCirc= s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("This isn't a Circle");
                }

                if (s is Circle)
                {
                    Console.WriteLine("This isn't a Rectangle");
                }

                object circ1 = new Circle(4);
                // You can store any class as a base class and then call the subclass methods 
                // even if they don't exist in base class
                Circle circ2 = (Circle)circ1;
                Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());
            }
        }
    }
}
