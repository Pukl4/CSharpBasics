namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Division(int x, int y)
            {
                return x / y;
            }

            try
            {
                //The program will throw an exception when we try to divide by 0
                Division(10, 0);
            }
            catch (Exception ex) 
            {
                //Code that run when exception is thrown 
                Console.WriteLine("An exception was thrown");
                Console.WriteLine(ex.Message);
            }
            //We can use a finally block to run code after a try-catch block 
            finally 
            {
                Console.WriteLine("This code always runs");
            }
        }
    }
}
