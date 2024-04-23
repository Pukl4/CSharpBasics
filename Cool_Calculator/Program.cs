using System;
using System.Collections.Generic;

NicksCoolCalculator calculator = new(
    "Welcome to Nick's Cool Calculator!");
calculator.Start();

public sealed class NicksCoolCalculator
{
    private string _greeting;

    public NicksCoolCalculator(string greeting)
    {
        _greeting = greeting;
    }

    public void Start()
    {
        Console.WriteLine(_greeting);

        Dictionary<string, string> supportedOperators = new()
        {
            { "+", "Add" },
            { "/", "Divide" },
            { "-", "Subtract" },
            { "*", "Multiply" }
        };

        while (true)
        {
            Console.WriteLine("Operator choices are as follows:");
            foreach (var op in supportedOperators)
            {
                Console.WriteLine($"{op.Value}: {op.Key}");
            }

            Console.WriteLine("Enter an operator:");
            string operatorChoice = Console.ReadLine();

            if (!supportedOperators.TryGetValue(operatorChoice, out var selectedOperatorDescription))
            {
                Console.WriteLine("Invalid operator choice.");
                continue;
            }

            Console.WriteLine($"You selected: {selectedOperatorDescription}");
            Console.WriteLine();

            Console.WriteLine(
                $"Recall that integers are on the range {int.MinValue} to {int.MaxValue}!");
            Console.WriteLine();

            int firstNumber;
            int secondNumber;

            while (true)
            {
                Console.WriteLine("Enter the first integer:");
                string firstNumberInput = Console.ReadLine();
                if (!int.TryParse(firstNumberInput, out firstNumber))
                {
                    Console.WriteLine(
                        $"{firstNumberInput} could not be parsed as an integer!");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the second integer:");
                string secondNumberInput = Console.ReadLine();
                if (!int.TryParse(secondNumberInput, out secondNumber))
                {
                    Console.WriteLine($"{secondNumberInput} could not be parsed as an int.");
                    continue;
                }

                if (operatorChoice == "/" && secondNumber == 0)
                {
                    Console.WriteLine(" Divisor cannot be 0");
                    continue;
                }   
                break;
            }


            while (true)
            {
                int result;
                try
                {
                    result = operatorChoice switch
                    {
                        "+" => firstNumber + secondNumber,
                        "/" => firstNumber / secondNumber,
                        "*" => firstNumber * secondNumber,
                        "-" => firstNumber - secondNumber,
                        _ => throw new NotSupportedException($"Arithmetics is not currently supported for operator {operatorChoice}.")
                    };
                }

                catch (Exception ex)
                {
                    Console.WriteLine(
                        $"There was an unhandled exception: {ex.Message}");
                    continue;
                }
                Console.WriteLine($"The result is: {result}");
                break;
            }

                    
            while (true)
            {
                Console.WriteLine("Do you want to continue?");
                string response = Console.ReadLine();
                if (string.Equals(response, "yes", StringComparison.InvariantCultureIgnoreCase))
                {
                    continue;
                }
                if (string.Equals(response, "no", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input, try again");
                    continue;
                }
            }    
        }
    }             
}
