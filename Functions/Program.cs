namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*A return value is a value that is returned from a method to the code that called it
             * Methods with return values are called functions 
             * Return value must be the same type as the method
             */

            //Example of a function
            int Add(int a, int b)
            {
                return a + b;
            }
            //Calling method:
            int sum=Add(5, 3);

            //Another way of calling function:
            int x = 5;
            int y = 3;
            int sum2=Add(x, y);

            //We can combine functions in one:
            int sum3=Add(Add(x, y), Add(5,6));
        }
    }
}
