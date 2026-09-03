namespace WeatherPredictorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            // Asking for user input
            Console.WriteLine("Enter the number of days");
            int days = int.Parse(Console.ReadLine().Trim());

            double[] temperature = new double[days];
            // Creating an array with weather conditions
            string[] conditions = { "sunny", "rainy", "foggy", "snowy" };
            string[] weatherConditions = new string[days];

            // Creating instance of Random class and 
            // assigning random value to each day
            
            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-20, 20);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];

                while(temperature[i] > 0 && weatherConditions[i] == "snowy")
                {
                    weatherConditions[i] = conditions[random.Next(conditions.Length)];
                }
            }

            for (int number = 0; number < days; number ++) 
            { 
                Console.WriteLine($"It is {temperature[number]} °C and {weatherConditions[number]}");
            }
            Console.WriteLine($"The average temperature is {CalculateAverage(temperature, days)} °C");
        }
        static double CalculateAverage(double[] temperature, int days)
        {
            double averageTemperature = 0;
            foreach (double i in temperature) { averageTemperature += i; };
            return (averageTemperature / days);
        }
    }
}
