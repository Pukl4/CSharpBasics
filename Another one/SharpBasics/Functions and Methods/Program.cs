namespace Functions_and_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleMethod();
            SimpleMethodSpec("Some text");
        }
        static void SimpleMethod()
        {
            Console.WriteLine("Hardcoded text");
        }
        static void SimpleMethodSpec(string spec)
        {
            Console.WriteLine($"{spec}");
        }
    }
}
