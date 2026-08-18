namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Implicit conversion
            // Defining integer
            int number = 12;

            // As long, double and float can store the higher number than int
            // we can parse them just by assigning values
            long lng = number;
            float flt = number;
            double dbl = number;

            // Same goes for the float-double
            float flt2 = 12.12f;
            double dbl2 = flt2;
        }
    }
}
