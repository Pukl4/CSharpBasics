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
            { "/", "Divide" }
        };

        bool end= false;
        while (end == false)
        {
            Console.WriteLine("Operator choices are as follows:");
            foreach (var op in supportedOperators)
            {
                Console.WriteLine($"{op.Value}: {op.Key}");
            }

            Console.WriteLine("Enter an operator:");
            string operatorChoice = Console.ReadLine();

            if (!supportedOperators.TryGetValue(
                operatorChoice, 
                out var selectedOperatorDescription))
            {
                Console.WriteLine("Invalid operator choice.");
                continue;
            }

            Console.WriteLine($"You selected: {selectedOperatorDescription}");
            Console.WriteLine();

            Console.WriteLine(
                $"Recall that integers are on the range " +
                $"{int.MinValue} to {int.MaxValue}!");
            Console.WriteLine();
            
            while (end == false) 
            {
                Console.WriteLine("Enter the first integer:");
                string firstNumberInput = Console.ReadLine();
                if (!int.TryParse(firstNumberInput, out int firstNumber))
                {
                    Console.WriteLine(
                        $"{firstNumberInput} could not be parsed as an integer!");
                    continue;
                }

                while (end == false)
                {
                    Console.WriteLine("Enter the second integer:");
                    string secondNumberInput = Console.ReadLine();
                    if (!int.TryParse(secondNumberInput, out int secondNumber))
                    {
                        Console.WriteLine($"{secondNumberInput} could not be parsed as a double.");
                        continue;
                    }

                    int result;

                    while (end == false)
                    {
                        try
                        {
                            result = operatorChoice switch
                            {
                                "+" => firstNumber + secondNumber,
                                "/" => firstNumber / secondNumber,
                                _ => throw new NotSupportedException(
                                    $"Arithmetic is not currently supported " +
                                    $"for operator {operatorChoice}.")
                            };
                        }
                        catch (DivideByZeroException)
                        {
                            Console.WriteLine("You cannot divide by zero.");
                            continue;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(
                                $"There was an unhandled exception: {ex.Message}");
                            continue;
                        }

                        Console.WriteLine($"The result is: {result}");

                        Console.WriteLine("Do you want to continue?");
                        string loop=Console.ReadLine();
                        if (loop=="yes")
                        {
                            continue;
                        }
                        else
                        {
                            end = true;
                        }

                        
                        
                    }
                               
                    
            
                }
                
            }
            
        }
    }
}