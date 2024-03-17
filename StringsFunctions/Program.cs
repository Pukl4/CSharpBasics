namespace StringsFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "Trying out functions";

            /*{0} is line, which will be replaced with the function after the comma
             *"Length" is used for getting number of characters of exact string*/
            Console.WriteLine("String length : {0}", test.Length);

            //"Contains" is used for searching specific data in string 
            Console.WriteLine("Does string contains 'off'? : {0}", test.Contains("off"));

            //"IndexOf" is used for getting index position of data, count starts from 0
            Console.WriteLine("Index of 'out' is : {0}", test.IndexOf("out"));

            //"Remove" is used for deleting specified index, first number is index, second is quantity of deleting characters
            Console.WriteLine("Removing index : {0}", test.Remove(7, 3));

            //"Insert"ius used for inserting new word into string from specified index 
            Console.WriteLine("Inserting string : {0}", test.Insert(11, "new "));

            //"Replace" is used for replacing word in string, left is an old one, second word is the new one 
            Console.WriteLine("Replacing string : {0}", test.Replace("out", "new"));

            /*"Compare" is used for finding out which string preceeds to another
            StringComparison specifies the rules of comparison
            OrdinalIgnoreCase = ignoring cases */
            Console.WriteLine("Compare A to B : {0}", String.Compare("A", "B", StringComparison.OrdinalIgnoreCase));


            Console.WriteLine("Pad Left : {0}", test.PadLeft(20, '.'));
            Console.WriteLine("Pad Right : {0}", test.PadRight(20, '.'));

            //Trim for getting rid of whitespaces
            Console.WriteLine("Trim : {0}", test.Trim());


            // -Upper and -lowercase are reting string in specified way
            Console.WriteLine("Uppercase : {0}", test.ToUpper());
            Console.WriteLine("Lowercase : {0}", test.ToLower());

            /* "\n" for adding new line 
             * "@" before the "" to print exact sentance*/
            string Story = String.Format("{0} saw a {1} {2} in the {3}", "Paul", "rabbit", "eating", "woods");
            Console.Write(Story + "\n");
            Console.WriteLine(@"Do exactly as i say + \n");
        }
    }
}
