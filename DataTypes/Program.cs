namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //convert sting to bool
            bool boolFromStr = bool.Parse("true");

            //convert string to int
            int intFromStr = int.Parse("100");

            //convert int to string
            string strVal = intFromStr.ToString();

            //Getting the data type variable
            Console.WriteLine($"Data type: {strVal.GetType()}");

            //Explicit Conversion ( losing some data during conversion)
            double dblNum = 12.345;
            Console.WriteLine($"Integer: {(int)dblNum}");

            //Implicit Conversion (smaller type  into larger with no data loss  during conversion)
            int intNum = 10;
            long longNum = intNum;

        }
    }
}
