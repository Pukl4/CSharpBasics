namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While loop syntax:
            int number = 0;
            while (number < 5)
            {
                Console.WriteLine(number);
                number++;
            }
            Console.WriteLine($"Total count is {number}");

            //Do while loop does one cycle and after it is done, the condition is checked
            int count = 0;
            do
            {
                Console.WriteLine(count);
                count++;
            } while (count > 5);
            Console.WriteLine($"Total count is {count}");

            count = 0;
            while (count < 5)
            {
                if (count == 3)
                {
                    count++;
                    Console.WriteLine("Skipping 3");
                    continue;
                }

                Console.WriteLine(count);
                count++;

                if (count == 5)
                {
                    Console.WriteLine("Out of here!");
                    break;
                }
            }
        }
    }
}
