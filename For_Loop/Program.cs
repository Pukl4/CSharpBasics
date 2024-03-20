namespace For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
         /* A for loop has three parts:
          * 1. The initializer: int i = 0;
          * 2. The condition: i <10;
          * 3. The iterator: i++*/
         // We can't access i outside of the loop

         for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
         Console.WriteLine("----------------------------");
         for (int i = 0;i < 10; i++) 
            {
                if (i == 5)
                {
                    Console.WriteLine("Out");
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------------");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine("Skipping 5");
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------------");



        }
    }
}
