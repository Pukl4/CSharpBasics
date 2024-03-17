namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Dictionaries also dynamic in size, but instead of index values, they hold key values pairs
             * We can:
             *     -get values from a dictionary;
             *     -set values in a dictionary;
             *     -add values;
             *     -remove values;
             *     -clear'
             *     -check if dictionary contains key
             *     
             *    !Keys in dictionary must to be unique, values don't!*/

            //Declaring a dictionary: Dictionary<key data type, value data type> name =new();
            Dictionary<string, int> wordsToNumbers = new();

            //Adding pairs:
            wordsToNumbers.Add("one", 1);
            wordsToNumbers.Add("two", 2);
            wordsToNumbers.Add("three", 3);

            //Getting values:
            int one = wordsToNumbers["one"];
            int two = wordsToNumbers["two"];
            int three = wordsToNumbers["three"];

            //Setting new value of a key:
            wordsToNumbers["one"] = 111;
            wordsToNumbers["two"] = 222;

            //Another ways of declaring a dictionary:

            Dictionary<int, string> numToWords = new()
            {
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
            };

            Dictionary<int, string> numToWords2 = new()
            {
                [1] = "one",
                [2] = "two",
                [3] = "three",
                [4] = "four",
            };

            //Counting a dictionary, giving number of pairs 
            int count = numToWords2.Count;

            //Clearing a dictionary:
            numToWords.Clear();

            //Checking if contains a key:
            bool contains = numToWords2.ContainsKey(3);

            //Checking and getting a value:
            //                 

            bool contains1 = numToWords2.TryGetValue(
                3,
                out string? value);

            //Using indexer to add or set values, which will overwrite existing values
            wordsToNumbers["one"] = 1;
            numToWords2[1] = "one";





        }
    }
}
