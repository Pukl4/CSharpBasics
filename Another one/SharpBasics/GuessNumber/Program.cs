namespace GuessNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numbRand = new Random();
            int number = numbRand.Next(1,11);
            bool guessedRight = false;

            Console.WriteLine("Enter a number from 1 to 10: ");
            
            int guess = 0;

            while (!guessedRight) 
            {
                int input = int.Parse(Console.ReadLine());

                if (input < number) 
                {
                    Console.WriteLine("Your number is lower, try again: "); 
                }
                else if (input > number) 
                {
                    Console.WriteLine("Your number is higher, try again: "); 
                }
                else if (input == number) 
                {
                    Console.WriteLine($"You are correct, it took {guess} guesses"); 
                    guessedRight = true;
                }
                else { Console.WriteLine("Please try again"); }
                guess++;
            }
        }
    }
}
