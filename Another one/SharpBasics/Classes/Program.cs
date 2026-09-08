using System.Security.Cryptography.X509Certificates;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car toyota = new Car("Toyota", "Corolla", 1999);
            Car honda = new Car("Honda", "Civic", 2005);
            Car bmw = new Car("BMW", "", 2020);
        }
    }
}
