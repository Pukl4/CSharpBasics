using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car("Toyota", "Corolla", 1999, false);
            Car honda = new Car("Honda", "Civic", 2005, false);
            Car audi = new Car("Audi", "A6", 2015, true);
            Car bmw = new Car("BMW", "i7", 2020, true);

            Car.PrintSmth();
            Console.WriteLine($"The number of cars produced: {Car.CarNumber}");
        }
    }
}
