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

            // while loop runs as long as the specified boolean condition evaluates to true
            // Syntax: while(condition) { code };
            int index = 0;
            bool whileExample = false;

            while (!whileExample) 
            {
                Console.WriteLine("Still going");
                index ++;
                if (index >= 6) 
                {
                    whileExample = true;
                };
            };
            Console.WriteLine($"Ended after {index} times");
        }
    }
}
