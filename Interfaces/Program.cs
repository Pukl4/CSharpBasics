namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle Ford = new Vehicle("Ford", 4, 160);
            if (Ford is IDrivable)
            {
                Ford.Move();
                Ford.Stop();
            }
            else
            {
                Console.WriteLine("The {0} can't be driven", Ford.Brand);
            }
        }
    }
}
