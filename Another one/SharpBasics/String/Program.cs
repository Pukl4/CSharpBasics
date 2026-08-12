namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring a string variable
            string declaringTwo;

            // Assigning a value to the declaringTwo variable
            declaringTwo = "Declaring that way";

            // Overwriting the variable name
            declaringTwo = "Overwritten value";
            string declaring = "Declaring the string this way";

            Console.WriteLine(declaring);
            Console.WriteLine(declaringTwo);

            // Taking the user input and storing it in a variable
            string userInput = Console.ReadLine();
            // Displaying the user input
            Console.WriteLine("Output is: " + userInput);
            Console.ReadKey();
        }
    }
}
