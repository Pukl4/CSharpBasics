namespace Functions_and_Methods
{
    internal class Program
    {
        // Field (or instance variable)
        int result;
        static void Main(string[] args)
        {
            SimpleMethod();
            SimpleMethodSpec("Some text");
            Console.WriteLine(Add(5, 19));
        }
        static void SimpleMethod()
        {
            Console.WriteLine("Hardcoded text");
        }
        static void SimpleMethodSpec(string spec)
        {
            Console.WriteLine($"{spec}");
        }
        static int Add(int x, int y) 
        {
            int result = x + y;
            return result;
        }
    }
}
