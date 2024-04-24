namespace Functions
{
    internal class Program
    {
        /*-------- FUNCTIONS------------
         * <Access Specifier> <Return type> <Method Name> (Parameters)
         * {<Body>}
         */
        /*Access Specifier determines whether the function can be called from another class:
         * 
         * public : Can be accessed from another class
         * private : Can't be accessed from another class
         * protected : Can't be accessed by class and derived class
         */
        

        static void DoubleIt(int x, out int solution)
        {
            solution = x * 2;
        }

        //
        public static void Swap( ref int num3, ref int num4 )
        {
            int temp = num3;
            num3 = num4;   
            num4 = temp;
        }



       
        static void Main(string[] args)
        {
            int num3 = 10;
            int num4 = 20;
            Console.WriteLine("Before Swap num1 : {0}, num2 : {1}", num3, num4);
            Swap( ref num3, ref num4 );
            Console.WriteLine("Before Swap num1 : {0}, num2 : {1}", num3, num4);





            int solution;
            DoubleIt(15, out solution);
            Console.WriteLine("15 * 2 = {0}", solution);

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
