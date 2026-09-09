namespace MultipleConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer ronny = new Customer("Ronny", "Round", "111-111-111");
            Customer bonny = new Customer("Bonny");

            Console.WriteLine($"{ronny.LastName}\n{bonny.FirstName}");
        }
    }
}
