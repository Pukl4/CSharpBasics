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
                $"Recall that integers are on the range {double.MinValue} to {double.MaxValue}!");
            Console.WriteLine();

            double firstNumber;
            double secondNumber;

            while (true)
            {
                Console.WriteLine("Enter the first double:");
                string firstNumberInput = Console.ReadLine();
                if (!double.TryParse(firstNumberInput, out firstNumber))
                {
                    Console.WriteLine(
                        $"{firstNumberInput} could not be parsed as an double!");
                    continue;
                }
                break;
            }

            while (true)
            {
                Console.WriteLine("Enter the second double:");
                string secondNumberInput = Console.ReadLine();
                if (!double.TryParse(secondNumberInput, out secondNumber))
                {
                    Console.WriteLine($"{secondNumberInput} could not be parsed as an double.");
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
                double result;
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

         
            Console.WriteLine("Do you want to continue?");
            string response = Console.ReadLine();
            if (string.Equals(response, "yes", StringComparison.InvariantCultureIgnoreCase))
            {
                continue;
            }
            else
            {
                break;
            }        
        }
    }             
}
