namespace simpleCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO: Implement the calculator logic here
            Console.WriteLine("Enter the first number: ");
            double inputNum1 = Convert.ToDouble(Console.ReadLine().Trim());

            Console.WriteLine("Enter the second number: ");
            double inputNum2 = Convert.ToDouble(Console.ReadLine().Trim());
            Console.WriteLine("Choose an operation: +, -, *, /");
            string inputOperator = Console.ReadLine().Trim();
            switch (inputOperator)
            {
                case "+":
                    Console.WriteLine($"Result: {inputNum1 + inputNum2}");
                    break;

                case "-":
                    Console.WriteLine($"Result: {inputNum1 - inputNum2}");
                    break;

                case "*":
                    Console.WriteLine($"Result: {inputNum1 * inputNum2}");
                    break;

                case "/":
                    if (inputNum2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    { Console.WriteLine($"Result: {inputNum1 / inputNum2}"); }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                    break;
            }
        }
    }
}
