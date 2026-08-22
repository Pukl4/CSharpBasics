namespace Logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool verificationCompleted = false;
            bool verificationStarted = true;

            // If statements executes code only when the statement is true
            if (verificationCompleted) { Console.WriteLine("OK"); }

            /* Logical operators are: 
                    AND  && — both statements are true
                    OR   || - one of the statements is true
                    NOT  !  - reverse the boolean condition 
            */

            // Won't execute code as one of the variables is false
            if (verificationStarted && verificationCompleted) { Console.WriteLine("You can proceed"); }

            // Code will be executed as verificationCompleted is reversed
            if (verificationStarted && !verificationCompleted) { Console.WriteLine("Please try again"); }

            // Code will be executed as one of the variables is true
            if (verificationStarted || verificationCompleted) { Console.WriteLine("Processing"); }

            // Relational operators are < <= > >=
            // Boolean are false by default and turn into true only after initialization

            int num1 = 6;
            int num2 = 8;

            bool isGreater = num1 > num2;

            if (num1 > 5) { Console.WriteLine("Is greater"); }

            // Else is a statement which will be executed if the if statement is false

            if (isGreater)
            {
                Console.WriteLine("Is greater");
            } 
            else if ((num1 + num2) > 10) 
            { 
                Console.WriteLine("Sum is greater"); 
            }
            else
            {
                Console.WriteLine("Isn't greater");
            }
            // Equality operators are == (equal) != (not equal)

            // Incrementing/Decrementing of integer
            int num = 0;
            num++; // will increase the number by 1
            num--; // will decrease the number by 1

            // Pre-incrementing means it will increase the number after the line is executed
            ++num;
            --num;

            //Incrementing by certain value
            num += 30;
            num -= 30;
            num *= 10;
            num /= 10;
            num %= 10;

        }
    }
}
