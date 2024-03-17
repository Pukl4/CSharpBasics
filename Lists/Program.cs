namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Lists  are zero based 
             *        are dynamic in size 
             * We can: 
             *        -get values from a list;
             *        -set values in a list;
             *        -add values;
             *        -remove values;
             *        -insert values;
             *        -clear and sort a list;
             */

            //Declaring a list, <> (generics) does mean that list is not limited to a specific data type 
            List<string> words = new List<string>(); // or List<string> list = new ();

            //Adding values to a list:
            words.Add("One");
            words.Add("Two");
            words.Add("Three");

            //Getting value from a list:
            string FirstValue = words[0];
            string SecondValue = words[1];
            string ThirdValue = words[2];

            //Setting new value
            words[0] = "Four";

            List<int> numbers = new()
            {
                    1,
                    2,
                    3,
                    4,
            };

            //Remove is not index base, it's removing specific value with the element
            numbers.Remove(1);
            numbers.Remove(2);
            numbers.Remove(3);


            //Inserting data in a list, syntax: list.Insert("index", "data")
            numbers.Insert(0, 1);
            numbers.Insert(2, 2);
            numbers.Insert(3, 3);

            //Clearing a list 
            numbers.Clear();

            //Sorting a list. If string - alphabetical order, if int - ascending order
            words.Sort();
            numbers.Sort();















        }
    }
}