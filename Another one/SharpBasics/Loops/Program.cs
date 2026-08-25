namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // For loop is used to run the code specific number of times
            // Syntax: 
            // for (initializer; condition; iterator) { code };
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"i = {i}");
            }

            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"countdown i = {i}");           
            }           
        }
    }
}
