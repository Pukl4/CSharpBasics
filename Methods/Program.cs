namespace Methods
{
    internal class Program
    {
        /*The parameters go into the parantheses of the method
         the arguments go into the parantheses of the method call*/
        static void Main(string[] args)
        {
            static void NewMethod(string name, int age)
            {
                //the method body
            }

            //Example of of a method call with arguments
            NewMethod("Nick", 23);

            //We can add a parameter to the method to make it more flexible 
            static void Separator() 
            {
                Console.WriteLine("----------");
            }

            static void Header(string name)
            {
                Separator();
                Console.WriteLine(name);
                Separator();
            }
            Header("Example 1");
            Header("Example 2");
            Header("Example 3");

        }
    }
}
