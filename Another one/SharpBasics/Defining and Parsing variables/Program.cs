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
        }
    }
}
