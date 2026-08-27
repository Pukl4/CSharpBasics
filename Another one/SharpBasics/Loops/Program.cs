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

            // do while loop executes code one time and then check if the confidion was met

            int numb;
            do
            {
                Console.WriteLine("Enter a number: ");
                numb = int.Parse(Console.ReadLine());
                numb+=5;
                Console.WriteLine("One time for sure");
            } while(numb <= 10);

            // break statement is used to stop executing the loop after certain condition are met
            // continue statement keeps the loop running but skips specific steps based on a condition
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                {
                    break; // Exits the loop entirely when i becomes 5
                }
                Console.WriteLine(i);
            }
        }
    }
}
