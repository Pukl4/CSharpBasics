namespace ArrayPracticeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a simple C# program that initializes a 3x3 two-dimensional array with integers,
            // calculates the sum of each row, and prints the sums to the console.

            int[,] intArray = new int[3, 3]
                {
                     { 1, 2, 3 },
                     { 4, 5, 6 },
                     { 7, 8, 9 },
                };
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 0; i < 3; i++)
            {
                sum1 += intArray[0,i];
            }
            for (int i = 0; i < 3; i++) 
            {
                sum2 += intArray[1, i];
            }
            for (int i = 0; i < 3; i++)
            {
                sum3 += intArray[2, i];
            }

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }
    }
}
