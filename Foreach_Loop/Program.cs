namespace Foreach_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Foreach loop syntax:
             * 
            foreach(Type object in collection_of_objects)

            {
                Do smth 
            }

            */

            int[] numbers = { 1, 2, 3, 4, 5, };
            foreach (int number in numbers) 
            {
                Console.WriteLine(number);
            }

            List <string> words = new()
            {
                "red",
                "green",
                "orange",
            };

            foreach (string word in words) 
            {
                Console.WriteLine(word);
            }

            Dictionary<string, int> ages = new()
            {
                {"Alice", 25 },
                {"George", 26 },
                {"Nick", 23}
            };

            foreach (var person in ages) 
            {
                Console.WriteLine($"{person.Key} is {person.Value} years old");
            }

            foreach (int number in numbers) 
            {
                if (number == 3) 
                {
                    break;
                }
                Console.WriteLine(number);
            }





        }
    }
}
