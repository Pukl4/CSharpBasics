namespace Defining_and_Parsing_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Defining or setting up a variable 
            int basenumber = 0;

            Console.WriteLine("Enter a whole number:");

            // Storing the user input into the variable
            string userInput = Console.ReadLine();

            basenumber = int.Parse(userInput);
            Console.WriteLine($"The number you entered is: {basenumber}");

            // Initializing two variables
            Console.WriteLine("Enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            Console.WriteLine("The result of " + firstNumber + " + " + secondNumber + " is " + sum);
        }
    }
}
