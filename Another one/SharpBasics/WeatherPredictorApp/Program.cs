namespace WeatherPredictorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking for user input
            Console.WriteLine("Enter the number of days");
            int days = int.Parse(Console.ReadLine().Trim());

            int[] temperature = new int[days];
            // Creating an array with weather conditions
            string[] conditions = { "Sunny", "Rainy", "Foggy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();
        }
    }
}
